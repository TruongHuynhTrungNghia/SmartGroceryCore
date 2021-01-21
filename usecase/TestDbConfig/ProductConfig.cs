using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace usecase.TestdbConfig
{
    public class productConfig : IEntityTypeConfiguration<model.Product>
    {
        public void Configure(EntityTypeBuilder<model.Product> builder)
        {
            builder.Property(p => p.Name)
            .HasMaxLength(50)
            .IsRequired(true);

            builder.Property(p => p.ManufactoringDate)
            .IsRequired();

            builder.Property(p => p.ExpiredDate)
            .IsRequired();

            builder.Property(p => p.Categrory)
            .HasMaxLength(50)
            .IsRequired(true);
        }
    }
}