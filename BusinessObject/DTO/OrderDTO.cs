using BusinessObject.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BusinessObject.DTO
{
    public class OrderDTO
    {
        public string? Id { get; set; }
        public int ProductId { get; set; }
        public int MemberId { get; set; }

        [DisplayName("Order Date")]
        public DateTime OrderDate { get; set; }

        [DisplayName("Required Date")]
        public DateTime RequiredDate { get; set; }

        [DisplayName("Shipped Date")]
        public DateTime ShippedDate { get; set; }

        [Column(TypeName = "money")]
        [Precision(18, 2)]
        public decimal Freight { get; set; }

        [Column(TypeName = "money")]
        [Precision(18, 2)]
        public decimal UnitPrice { get; set; }

        [Precision(3, 2)]
        [Range(0, 1)]
        public int Quantity { get; set; }

        [Column(TypeName = "float")]
        public decimal Discount { get; set; }
    }
}
