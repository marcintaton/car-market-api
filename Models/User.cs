using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Login { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string DisplayName { get; set; }

        [RegularExpression(@"^[0-9]{9}$")]
        public string TelephoneNumber { get; set; }
    }
}
