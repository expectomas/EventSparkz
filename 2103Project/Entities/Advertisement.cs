using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2103Project.Entities
{
    public class Advertisement
    {
        public int advertisementID;
        public string imageDirectory;
        public string description;

        public Advertisement(int newAdvertisementId, string newImageDirectory, string newDescription)
        {
            advertisementID = newAdvertisementId;
            imageDirectory = newImageDirectory;
            description = newDescription;
        }
    }
}
