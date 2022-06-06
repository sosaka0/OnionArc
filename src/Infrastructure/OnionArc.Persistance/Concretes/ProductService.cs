using OnionArc.Application.Abstractions;
using OnionArc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArc.Persistance.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
                => new()
                {
                    new() { Id = Guid.NewGuid(), Name = "Product", Price = 100, Stock = 20 },
                    new() { Id = Guid.NewGuid(), Name = "Product2", Price = 200, Stock = 10 },
                    new() { Id = Guid.NewGuid(), Name = "Product3", Price = 300, Stock = 24 },
                    new() { Id = Guid.NewGuid(), Name = "Product4", Price = 400, Stock = 23 },
                    new() { Id = Guid.NewGuid(), Name = "Product5", Price = 500, Stock = 2 }
                };
    }
}
