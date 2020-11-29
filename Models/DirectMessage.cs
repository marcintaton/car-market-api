using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Models
{
    ///
    /// Model representing a single direct message entity
    ///
    public class DirectMessage
    {
        ///
        /// Unique key value
        ///
        [Key]
        public int Id { get; set; }

        ///
        /// Precise time of sending a message, as Unix timestamp
        ///
        public int TimePosted { get; set; }

        ///
        /// Id of authoring user
        ///
        public int UserIdFrom { get; set; }

        ///
        /// Id of receiving user
        ///
        public int UserIdTo { get; set; }

        ///
        /// Contents of the message
        ///
        [Column(TypeName = "nvarchar(500)")]
        public string MessageContent { get; set; }
    }
}
