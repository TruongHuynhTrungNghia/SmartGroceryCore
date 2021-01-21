using System;

namespace usecase.DAL
{
    public class CustomerDto
    {
        public Guid Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime DateofBirth { get; set; }
    }
}