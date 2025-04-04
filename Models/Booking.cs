using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEaseApp2.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

     //   [Required]
        public int EventId { get; set; }

      //  [Required]
        public int VenueId { get; set; }

      //  [Required]
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }

        // Navigation Properties with Foreign Keys
        [ForeignKey("EventId")]
        public Event? Event { get; set; }

        [ForeignKey("VenueId")]
        public Venue? Venue { get; set; }
    }
}
