using System;

namespace usecase.DAL
{
    public class ProductDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Categrory { get; set; }

        public DateTime ManufactoringDate { get; set; }

        public DateTime ExpiredDate { get; set; }
    }
}