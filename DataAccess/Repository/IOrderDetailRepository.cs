using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetAll();
        OrderDetail Get(int productId, int orderId);
        void Insert(OrderDetail detail);
        void Delete(int productId, int orderId);
        void Update(OrderDetail detail);
    }
}
