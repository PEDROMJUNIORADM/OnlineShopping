using OnlineShoppingStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShoppingStore.Domain.Entities;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private readonly EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }

        public void SaveProduct(Product product)
        {
            if (product.ProductId==0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product dbEntry =
                    context.Products.Find(product.ProductId);
                if (dbEntry!=null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Descric = product.Descric;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                    
                }
            }
            context.SaveChanges();
        }
    }
}
