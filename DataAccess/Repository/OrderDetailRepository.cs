using BusinessObject.Entity;
using BusinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        SalesManagementContext context;
        public OrderDetailRepository()
        {
            context = new SalesManagementContext();
        }
        public void Delete(int productId, int orderId)
        {
            context.OrderDetails.Remove(Get(productId, orderId));
        }

        public OrderDetail Get(int productId, int orderId) => context.OrderDetails.Find(productId, orderId);

        public IEnumerable<OrderDetail> GetAll()
        {
            return context.OrderDetails.ToList();
        }

        public void Insert(OrderDetail orderDetail)
        {
            if (orderDetail != null)
            {
                context.OrderDetails.Add(orderDetail);
                context.SaveChanges();
            }
        }

        public void Update(OrderDetail orderDetail)
        {
            if (orderDetail != null)
            {
                context.OrderDetails.Update(orderDetail);
                context.SaveChanges();
            }
        }
    }
}
