using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();
        Order Get(int id);
        void Insert(Order Order);
        void Delete(int id);
        void Update(Order Order);
    }
}
