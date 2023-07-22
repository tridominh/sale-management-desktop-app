using AutoMapper;
using BusinessObject.DTO;
using BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Profiles
{
    public class OrderProfile : Profile
    {
        public static void CreateMap(IMapperConfigurationExpression cfg)
        {
            // config chuyển đổi từ Employee => EmployeeDto
            var oMap = cfg.CreateMap<Order, OrderDTO>().ReverseMap();
            oMap.ForAllMembers(o => o.Ignore());
            oMap.ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.MemberId, opt => opt.MapFrom(s => s.MemberId))
                .ForMember(d => d.OrderDate, opt => opt.MapFrom(s => s.OrderDate))
                .ForMember(d => d.ShippedDate, opt => opt.MapFrom(s => s.ShippedDate))
                .ForMember(d => d.RequiredDate, opt => opt.MapFrom(s => s.RequiredDate))
                .ForMember(d => d.Freight, opt => opt.MapFrom(s => s.Freight));

            // config chuyển đổi từ EmployeeDto => Employee
            var dMap = cfg.CreateMap<OrderDetail, OrderDTO>().ReverseMap();
            dMap.ForAllMembers(d => d.Ignore());
            dMap.ForMember(d => d.ProductId, opt => opt.MapFrom(s => s.ProductId))
                .ForMember(d => d.UnitPrice, opt => opt.MapFrom(s => s.UnitPrice))
                .ForMember(d => d.Quantity, opt => opt.MapFrom(s => s.Quantity))
                .ForMember(d => d.Discount, opt => opt.MapFrom(s => s.Discount));
        }
    }
}
