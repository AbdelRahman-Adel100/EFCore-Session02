using EFCore_Session02.Configurations;
using EFCore_Session02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Session02.Contexts
{
    internal class EventHubContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHub;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BadgeConfiguration());
            modelBuilder.ApplyConfiguration(new EventConfiguration());
            modelBuilder.ApplyConfiguration(new OrganizerProfConfiguration());
        }
        DbSet<Attendee> Attendees { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<Badge> Badges { get; set; }
        DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        DbSet<Organizer> Organizers { get; set; }

    }
}