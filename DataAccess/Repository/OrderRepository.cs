using BusinessObject.Entity;
using BusinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        SalesManagementContext context;
        public OrderRepository()
        {
            context = new SalesManagementContext();
        }
        public void Delete(int id)
        {
            context.Orders.Remove(Get(id));
            context.SaveChanges();
        }

        public Order Get(int id) => context.Orders.Find(id);

        public IEnumerable<Order> GetAll()
        {
            return context.Orders.ToList();
        }

        public void Insert(Order order)
        {
            if (order != null)
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public void Update(Order order)
        {
            if (order != null)
            {
                context.Orders.Update(order);
                context.SaveChanges();
            }
        }
    }
}
