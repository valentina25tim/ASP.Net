using IlCats_Domain.Entity.Car;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ilcats_Persistence.Configuration
{ 
    public class CarConfiguration : IEntityTypeConfiguration<ModelCar>
    {
        public void Configure(EntityTypeBuilder<ModelCar> builder)
        {
            builder.Property(p => p.Name)
                .IsRequired().HasMaxLength(60);
        }
    }
} 