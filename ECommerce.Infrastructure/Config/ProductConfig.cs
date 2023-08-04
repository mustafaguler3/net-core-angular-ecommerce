using System;
using Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Infrastructure.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(i => i.Id).IsRequired();
            builder.Property(i => i.Name).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Description).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Price).IsRequired();//.HasColumnType("decimal(18,2)");
            builder.HasOne(i => i.ProductBrand).WithMany().HasForeignKey(i => i.ProductBrandId);
            builder.HasOne(i => i.ProductType).WithMany().HasForeignKey(i => i.ProductTypeId);
        }
    }
}

