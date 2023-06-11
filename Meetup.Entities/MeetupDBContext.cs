using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meetup.Entities
{
    public class MeetupDBContext : DbContext
    {
        public MeetupDBContext(DbContextOptions<MeetupDBContext> options) : base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
