﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.SQS;
using Amazon.SQS.Model;
using _2103Project.Entities;

namespace _2103Project.Action
{
    class Message
    {
        private const string AccessKeyId = "AKIAI7C3Q46RRQZJZIAA";
        private const string SecretAccessKey = "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";
        private const string MessageURLString = "https://queue.amazonaws.com/450425235326/EventSparkz";

        public enum TypeOfMsg {Announcement, Alerts, SystemMsg};
        TypeOfMsg pollingMsg;

        AmazonSQSClient objClient;

        private Advertisement CreateAdvertisement(string obtainedMsg)
        {
            string [] full = new string [3];

            full = obtainedMsg.Split('\n');

            string adId = full[0].ToString();
            string imageDirectory = full[1].ToString();
            string description = full[2].ToString();

            Advertisement newCreated = new Advertisement(Convert.ToInt32(adId), imageDirectory, description);

            return newCreated;
        }

        public Message(TypeOfMsg requestMsgType)
        {
            pollingMsg = requestMsgType;


            objClient = new AmazonSQSClient(AccessKeyId, SecretAccessKey);

            CreateQueueResponse queueResponse = new CreateQueueResponse();


            //Request existing queues
            ListQueuesResult allQueues = requestListOfQueuesInSQS();


            bool eventSparkzQueueListExists = false;

            foreach (string queueURL in allQueues.QueueUrl)
            {
                if (queueURL.Equals(MessageURLString))
                {
                    eventSparkzQueueListExists = true;
                }
            }

            if (!eventSparkzQueueListExists)
            {
                queueResponse = objClient.CreateQueue(new CreateQueueRequest()
                {
                    QueueName
                        = "EventSparkz"
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

        public List<Advertisement> checkMessages()
        {
            List<Advertisement> AdvertisementList = new List<Advertisement>();

            string fullMessage = string.Empty;
            string receiptHandle;

            string selectedQueue = MessageURLString;

            ReceiveMessageResponse queueReceiveMessageResponse = new ReceiveMessageResponse();

            queueReceiveMessageResponse = objClient.ReceiveMessage(new ReceiveMessageRequest()
            {
                QueueUrl = selectedQueue,
                MaxNumberOfMessages = 10
            });

            ReceiveMessageResult objReceiveMessageResult = new ReceiveMessageResult();

            objReceiveMessageResult = queueReceiveMessageResponse.ReceiveMessageResult;

            List<Amazon.SQS.Model.Message> messagesList = new List<Amazon.SQS.Model.Message>();

            messagesList = objReceiveMessageResult.Message;

            foreach (Amazon.SQS.Model.Message objMessage in messagesList)
            {
                fullMessage += objMessage.Body;
                receiptHandle = objMessage.ReceiptHandle;

                AdvertisementList.Add(CreateAdvertisement(fullMessage));
            }

            return AdvertisementList;
        }

        
    }
}
