using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2103Project.Entities
{
    public class Advertisement : IEquatable<Advertisement>
    {
        public int advertisementID;
        public string imageDirectory = string.Empty;
        public string description = string.Empty;

        public Advertisement(int newAdvertisementId, string newImageDirectory, string newDescription)
        {
            advertisementID = newAdvertisementId;
            imageDirectory = newImageDirectory;
            description = newDescription;
        }

        public bool Equals(Advertisement other)
        {
            if (this.advertisementID == other.advertisementID)
                return true;
            else
                return false;
        }
    }
}
