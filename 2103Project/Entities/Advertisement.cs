using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2103Project.Entities
{
    class Advertisement
    {
        int advertisementID;
        string imageDirectory;
        string description;

        public Advertisement(int newAdvertisementId, string newImageDirectory, string newDescription)
        {
            advertisementID = newAdvertisementId;
            imageDirectory = newImageDirectory;
            description = newDescription;
        }
    }
}
