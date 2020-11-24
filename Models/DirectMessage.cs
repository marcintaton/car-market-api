using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Models
{
    public class DirectMessage
    {
        [Key]
        public int Id { get; set; }

        public int TimePosted { get; set; }

        public int UserIdFrom { get; set; }

        public int UserIdTo { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string MessageContent { get; set; }
    }
}
