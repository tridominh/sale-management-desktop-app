using BusinessObject.DTO;
using BusinessObject.Entity;
using BusinessObject.Mapper;
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
        OrderMapper mapper = new OrderMapper();
        OrderRepository orderRepository = new OrderRepository();
        OrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public IEnumerable<OrderDTO> GetAll()
        {
            List<OrderDTO> list = new List<OrderDTO>();
            foreach(OrderDetail detail in orderDetailRepository.GetAll())
            {
                Order order = orderRepository.Get(detail.OrderId);
                var orderFull = mapper.toOrderDTO(order, detail);
                list.Add(orderFull);
            }
            return list;
        }

        public OrderDTO? Get(int oid, int pid)
        {
            return GetAll().Where(o => Convert.ToInt32(o.Id)==oid && o.ProductId==pid).FirstOrDefault();
        }

        public void Insert(OrderDTO orderDTO)
        {
            if (orderDTO != null)
            {
                Order order = mapper.toOrder(orderDTO);
                orderRepository.Insert(order);
                OrderDetail detail = mapper.toOrderDetail(orderDTO);
                detail.OrderId = order.Id;
                orderDetailRepository.Insert(detail);
            }
        }

        public void Update(OrderDTO orderDTO)
        {
            if(orderDTO!= null) {
                Order order = mapper.toOrder(orderDTO);
                orderRepository.Update(order);
                OrderDetail detail = mapper.toOrderDetail(orderDTO);
                orderDetailRepository.Update(detail);
            }
        }

        public void Delete(int oid, int pid)
        {
            var orderDTO = Get(oid, pid);
            if (orderDTO != null)
            {
                Order order = mapper.toOrder(orderDTO);
                OrderDetail detail = mapper.toOrderDetail(orderDTO);
                orderRepository.Delete(order.Id);
                orderDetailRepository.Delete(detail.ProductId, detail.OrderId);
            }
        }
    }
}
