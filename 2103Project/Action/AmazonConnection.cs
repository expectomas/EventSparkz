using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.SQS;
using Amazon.SQS.Model;
using _2103Project.Entities;

namespace _2103Project.Action
{
    class AmazonConnection : Connection
    {
        private const string AccessKeyId = "AKIAI7C3Q46RRQZJZIAA";
        private const string SecretAccessKey = "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";
        private const string QueueURLString = "https://queue.amazonaws.com/450425235326/EventSparkz";
        private const int numberOfMsgToFetch = 10;
        private const string EventSparkzQueueName = "EventSparkz";

        TypeOfMsg pollingMsg;

        AmazonSQSClient objClient;

        private Advertisement createAdvertisement(string obtainedMsg)
        {
            string [] full = new string [3];

            full = obtainedMsg.Split('\n');

            string adId = full[0].ToString();
            string imageDirectory = full[1].ToString();
            string description = full[2].ToString();

            Advertisement newCreated = new Advertisement(Convert.ToInt32(adId), imageDirectory, description);

            return newCreated;
        }

        public AmazonConnection(TypeOfMsg requestMsgType)
        {
            pollingMsg = requestMsgType;


            objClient = new AmazonSQSClient(AccessKeyId, SecretAccessKey);

            CreateQueueResponse queueResponse = new CreateQueueResponse();


            //Request existing queues
            ListQueuesResult allQueues = requestListOfQueuesInSQS();


            bool eventSparkzQueueListExists = false;

            foreach (string queueURL in allQueues.QueueUrl)
            {
                if (queueURL.Equals(QueueURLString))
                {
                    eventSparkzQueueListExists = true;
                }
            }

            if (!eventSparkzQueueListExists)
            {
                queueResponse = objClient.CreateQueue(new CreateQueueRequest()
                {
                    QueueName
                        = EventSparkzQueueName
                });
            }
        }

        private ListQueuesResult requestListOfQueuesInSQS()
        {
            ListQueuesResponse objqueuesResponseList = new ListQueuesResponse();

            objqueuesResponseList = objClient.ListQueues(new ListQueuesRequest());

            ListQueuesResult Result = objqueuesResponseList.ListQueuesResult;

            return Result;
        }

        public override List<Advertisement> checkMessages()
        {
            List<Advertisement> AdvertisementList = new List<Advertisement>();

            Advertisement newAd = new Advertisement(0,"0","0");

            int currentFetchCounter = 0;

            do
            {
                string fullMessage = string.Empty;
                string receiptHandle;

                string selectedQueue = QueueURLString;

                ReceiveMessageResponse queueReceiveMessageResponse = new ReceiveMessageResponse();

                queueReceiveMessageResponse = objClient.ReceiveMessage(new ReceiveMessageRequest()
                {
                    QueueUrl = selectedQueue,
                    MaxNumberOfMessages = 10,
                    VisibilityTimeout = 5

                });

                ReceiveMessageResult objReceiveMessageResult = new ReceiveMessageResult();

                objReceiveMessageResult = queueReceiveMessageResponse.ReceiveMessageResult;

                List<Amazon.SQS.Model.Message> messagesList = new List<Amazon.SQS.Model.Message>();

                if(objReceiveMessageResult.IsSetMessage())
                     messagesList = objReceiveMessageResult.Message;

                foreach (Amazon.SQS.Model.Message objMessage in messagesList)
                {
                    fullMessage += objMessage.Body;
                    receiptHandle = objMessage.ReceiptHandle;

                    newAd = createAdvertisement(fullMessage);

                    if(!AdvertisementList.Contains(newAd))
                        AdvertisementList.Add(newAd);
                }

                currentFetchCounter++;

            } while (currentFetchCounter<numberOfMsgToFetch);

            return AdvertisementList;
        }

        public override void sendMessage(Advertisement adv)
        {
            StringBuilder stBuilder = new StringBuilder();

            stBuilder.Append(adv.advertisementID);
            stBuilder.Append("\n");
            stBuilder.Append(adv.imageDirectory);
            stBuilder.Append("\n");
            stBuilder.Append(adv.description);

            string sendingString = stBuilder.ToString();

            try
            {
                objClient.SendMessage(new SendMessageRequest()
                {
                    MessageBody = sendingString,
                    QueueUrl = QueueURLString
                });
            }
            catch (Exception ex)
            {
                throw new AmazonSQSException("Sending Message to Queue Fail");
            }
        }
    }
}
