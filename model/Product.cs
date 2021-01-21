
using System;
using model.Common;

namespace model
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public string Categrory { get; set; }

        public DateTime ManufactoringDate { get; set; }

        public DateTime ExpiredDate { get; set; }
    }
}