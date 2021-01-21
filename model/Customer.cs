using System;
using System.Collections.Generic;
using model.Common;

namespace model
{
    public class Customer : Entity
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime DateofBirth { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}