using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wsei.Lab1.Entities;
using Wsei.Lab1.Models;

namespace Wsei.Lab1.Services
{
    public interface IProductService
    {
        Task Add(ProductModel product);

        Task<IEnumerable<ProductEntity>> GetAll(string name);
    }
}
