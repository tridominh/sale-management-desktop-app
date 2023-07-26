using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Entity
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int MemberId { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Order Date")]
        public DateTime OrderDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Required Date")]
        public DateTime RequiredDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Shipped Date")]
        public DateTime ShippedDate { get; set; }

        [Column(TypeName = "money")]
        [Precision(18, 2)]
        public decimal Freight { get; set; }
        public virtual Member Member { get; set; } = null!;
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
