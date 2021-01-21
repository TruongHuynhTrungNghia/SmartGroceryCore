using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using model;

namespace usecase.TestdbConfig
{
    public class CustomerContext : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(p => p.FirstName)
            .HasMaxLength(50)
            .IsRequired(true);

            builder.Property(p => p.LastName)
            .HasMaxLength(50)
            .IsRequired(true);

            builder.Property(p => p.DateofBirth)
            .IsRequired(true);
        }
    }
}