using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds;

public class ProductSeed : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(new Product 
        { 
            Id = 1, 
            CategoryId = 1,
            Name = "Pencil 1",
            Price = 100, 
            Stock = 10,
            CreatedDate = DateTime.Now 
        },
        new Product 
        { 
            Id = 2, 
            CategoryId = 1,
            Name = "Pencil 2",
            Price = 200,
            Stock = 30,
            CreatedDate = DateTime.Now 
        },
        new Product 
        { 
            Id = 3, 
            CategoryId = 1,
            Name = "Pencil 3",
            Price = 600, 
            Stock = 50,
            CreatedDate = DateTime.Now 
        },
        new Product 
        { 
            Id = 4, 
            CategoryId = 2,
            Name = "Book 1",
            Price = 100, 
            Stock = 10,
            CreatedDate = DateTime.Now 
        },
        new Product 
        { 
            Id = 5, 
            CategoryId = 2,
            Name = "Book 2",
            Price = 800, 
            Stock = 70,
            CreatedDate = DateTime.Now 
        });
    }
}