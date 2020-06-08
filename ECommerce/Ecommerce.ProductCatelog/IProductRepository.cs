using Ecommerce.ProductCatelog.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.ProductCatelog
{
    interface IProductRepository
    {
        Task AddProduct(Product product);

        Task<IEnumerable<Product>> GetAllProducts();

    }
}
