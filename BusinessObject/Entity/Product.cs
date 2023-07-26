using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Category Id")]
        public int CategoryId { get; set; }

        [StringLength(40)]
        [DisplayName("Product Name")]
        public string ProductName { get; set; } = null!;

        [StringLength(20)]
        public string Weight { get; set; } = null!;

        [Column(TypeName ="money")]
        [Precision(18, 2)]
        [DisplayName("Unit Price")]
        public decimal UnitPrice { get; set; }

        [DisplayName("Unit in stock")]
        public int UnitInStock { get; set; }

        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
