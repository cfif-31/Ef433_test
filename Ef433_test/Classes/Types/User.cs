using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef433_test.Classes.Types
{
    public class User
    {
        public enum userType:sbyte { 
            user,
            admin
        }
        [Key]
        public int UserId { get; set; }
        [Required, MaxLength(128)]
        public string UserFullName { get; set; }
        [Required, MaxLength(32)]
        public string UserLogin { get; set; }
        [Required, MaxLength(32)]
        public string UserPass { get; set; }
        public userType UserType { get; set; }
    }
}
