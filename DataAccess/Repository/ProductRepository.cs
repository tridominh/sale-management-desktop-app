using BusinessObject.Entity;
using BusinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository
    {
        SalesManagementContext context;
        public ProductRepository()
        {
            context = new SalesManagementContext();
        }
        public void Delete(int id)
        {
            context.Products.Remove(Get(id));
        }

        public Product Get(int id) => context.Products.Find(id);

        public IEnumerable<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public void Insert(Product product)
        {
            if (product != null)
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            if (product != null)
            {
                context.Products.Update(product);
                context.SaveChanges();
            }
        }
    }
}
