using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef433_test.Classes.Types
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public virtual User user { get; set; }
        public virtual List<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }
    }
}
