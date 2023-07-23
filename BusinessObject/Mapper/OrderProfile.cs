using BusinessObject.DTO;
using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Mapper
{
    public class OrderMapper
    {
        public OrderDTO toOrderDTO(Order order, OrderDetail detail)
        {
            return new OrderDTO()
            {
                Id = order.Id+"",
                MemberId = order.MemberId,
                OrderDate = order.OrderDate,
                RequiredDate = order.RequiredDate,
                ShippedDate = order.ShippedDate,
                Freight = order.Freight,
                ProductId = detail.ProductId,
                UnitPrice = detail.UnitPrice,
                Quantity = detail.Quantity,
                Discount = detail.Discount,
            };
        }
        public Order toOrder(OrderDTO orderDTO) 
        {
            return new Order()
            {
                MemberId = orderDTO.MemberId,
                OrderDate = orderDTO.OrderDate,
                RequiredDate = orderDTO.RequiredDate,
                ShippedDate = orderDTO.ShippedDate,
                Freight = orderDTO.Freight,
            };
        }
        public OrderDetail toOrderDetail(OrderDTO orderDTO)
        {
            return new OrderDetail()
            {
                OrderId = Convert.ToInt32(orderDTO.Id),
                ProductId = orderDTO.ProductId,
                UnitPrice = orderDTO.UnitPrice,
                Quantity = orderDTO.Quantity,
                Discount = orderDTO.Discount,
            };
        }
    }
}
