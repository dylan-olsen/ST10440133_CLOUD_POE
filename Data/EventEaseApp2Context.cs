using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventEaseApp2.Models;

namespace EventEaseApp2.Data
{
    public class EventEaseApp2Context : DbContext
    {
        public EventEaseApp2Context (DbContextOptions<EventEaseApp2Context> options)
            : base(options)
        {
        }

        public DbSet<EventEaseApp2.Models.Venue> Venue { get; set; } = default!;
        public DbSet<EventEaseApp2.Models.Event> Event { get; set; } = default!;
        public DbSet<EventEaseApp2.Models.Booking> Booking { get; set; } = default!;
    }
}
