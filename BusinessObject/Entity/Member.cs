using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Entity
{
    public class Member
    {
        public int Id { get; set; }

        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        [Required(ErrorMessage = "Please enter your e-mail address."), StringLength(50)]
        public string Email { get; set; } = null!;

        [StringLength(40)]
        public string CompanyName { get; set; } = null!;

        [StringLength(15)]
        public string City { get; set;} = null!;

        [StringLength(15)]
        public string Country { get; set; } = null!;

        [StringLength(30)]
        public string Password { get; set; } = null!;

        public virtual ICollection<Order>? Orders { get; set; }
    }
}
