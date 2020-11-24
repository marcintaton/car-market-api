using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Models
{
    public class CarListing
    {
        [Key]
        public int Id { get; set; }

        public int DateAdded { get; set; }

        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Brand { set; get; }

        [Column(TypeName = "nvarchar(20)")]
        public string Model { set; get; }

        public int ProductionYear { set; get; }

        public int Mileage { set; get; }

        public int Price { set; get; }

        [Column(TypeName = "nvarchar(1000)")]
        public string Descrition { get; set; }
    }
}
