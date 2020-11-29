using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Models
{
    ///
    /// Model representing a single user entity
    ///
    public class User
    {
        ///
        /// Unique key value
        ///
        [Key]
        public int Id { get; set; }

        ///
        /// Unique user alias used to log in
        ///
        [Column(TypeName = "nvarchar(20)")]
        public string Login { get; set; }

        ///
        /// User Password
        ///
        [Column(TypeName = "nvarchar(20)")]
        public string Password { get; set; }

        ///
        /// User alias shown to other users
        ///
        [Column(TypeName = "nvarchar(100)")]
        public string DisplayName { get; set; }

        ///
        /// User's telephone number, example of regex usage
        ///
        [RegularExpression(@"^[0-9]{9}$")]
        public string TelephoneNumber { get; set; }
    }
}
