using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_PhoneShop
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description);
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(p => p.Number).IsRequired();
        }
    }
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.OrderDate).IsRequired();
            builder.HasOne(o => o.Client);
        }
    }
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.Age).IsRequired();
            builder.ToTable(t => t.HasCheckConstraint("ValidAge", "Age > 0 and Age < 130"));
        }
    }

}
