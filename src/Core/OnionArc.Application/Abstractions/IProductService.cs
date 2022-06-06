using OnionArc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArc.Application.Abstractions
{
    public interface IProductService
    {
               List<Product> GetProducts();
    }
}
