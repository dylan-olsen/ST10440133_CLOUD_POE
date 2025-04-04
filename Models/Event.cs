using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventEaseApp2.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

       // [Required]
        [StringLength(100)]
        public string EventName { get; set; }

       // [Required]
        public DateTime EventDate { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        // Navigation
        public List<Booking>? Bookings { get; set; }
    }
}
