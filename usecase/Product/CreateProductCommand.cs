using MediatR;
using System;

namespace usecase.Product
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Categrory { get; set; }

        public DateTime ManufactoringDate { get; set; }

        public DateTime ExpiredDate { get; set; }
    }
}