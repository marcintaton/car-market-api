using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Models
{
    ///
    /// Model representing a single listing entity
    ///
    public class CarListing
    {
        ///
        /// Unique key value
        ///
        [Key]
        public int Id { get; set; }

        ///
        /// Precise time of listing being added, as Unix timestamp
        ///
        public int DateAdded { get; set; }

        ///
        /// ID of the user who added the listing
        ///
        public int UserId { get; set; }

        ///
        /// Brand of the listed car
        ///
        [Column(TypeName = "nvarchar(20)")]
        public string Brand { set; get; }

        ///
        /// Model of the listed car
        ///
        [Column(TypeName = "nvarchar(20)")]
        public string Model { set; get; }

        ///
        /// Production year of the listed car
        ///
        public int ProductionYear { set; get; }

        ///
        /// Mileage of the listed car
        ///
        public int Mileage { set; get; }

        ///
        /// Suggested price
        ///
        public int Price { set; get; }

        ///
        /// Additional details
        ///
        [Column(TypeName = "nvarchar(1000)")]
        public string Descrition { get; set; }
    }
}
