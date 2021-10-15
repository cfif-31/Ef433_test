using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef433_test.Classes.Types
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required, MaxLength(32)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }

        public virtual List<Order> orders { get; set; }

        public Product() {
            orders = new List<Order>();
        }

    }
}
