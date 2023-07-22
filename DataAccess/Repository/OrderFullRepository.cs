using AutoMapper;
using BusinessObject.DTO;
using BusinessObject.Entity;
using BusinessObject.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderFullRepository
    {
        IMapper mapper = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new OrderProfile());
        }).CreateMapper();

        OrderRepository orderRepository = new OrderRepository();
        OrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public IEnumerable<OrderDTO> GetAll()
        {
            List<OrderDTO> list = new List<OrderDTO>();
            foreach(OrderDetail detail in orderDetailRepository.GetAll())
            {
                Order order = orderRepository.Get(detail.OrderId);
                var orderFull = mapper.Map<Order,OrderDTO>(order);
                orderFull = mapper.Map(detail, orderFull);
                list.Add(orderFull);
            }
            return list;
        }
    }
}
