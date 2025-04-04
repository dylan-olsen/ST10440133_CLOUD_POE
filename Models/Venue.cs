using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventEaseApp2.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }

      //  [Required]
        [StringLength(100)]
        public string VenueName { get; set; }

       // [Required]
        [StringLength(255)]
        public string Location { get; set; }

     //   [Required]
        public int Capacity { get; set; }

        [StringLength(500)]
        public string? ImageUrl { get; set; }

        // Navigation
        public List<Booking>? Bookings { get; set; }
    }
}

