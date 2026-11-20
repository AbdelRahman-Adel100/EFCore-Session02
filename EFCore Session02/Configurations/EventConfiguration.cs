using EFCore_Session02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace EFCore_Session02.Configurations
{
    internal class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Events");

                builder.HasKey(e => e.EventId);

                builder.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsRequired();

                builder.Property(e => e.Description)
                    .IsRequired();

                builder.Property(e => e.StartDate)
                    .IsRequired();

                builder.Property(e => e.EndDate)
                    .IsRequired(false);

                builder.Property(e => e.MaxAttendees)
                    .IsRequired();
            }
    }
}
