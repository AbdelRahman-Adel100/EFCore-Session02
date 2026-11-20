using EFCore_Session02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Session02.Configurations
{
    internal class OrganizerProfConfiguration : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.ToTable("OrganizerProfiles");

            builder.HasKey(x => x.OrganizerProfileId);

            builder.Property(x => x.Biography)
                .HasMaxLength(500);

            builder.Property(x => x.WebsiteUrl)
                .HasMaxLength(500);

            builder.Property(x => x.LogoUrl)
                .HasMaxLength(500);


        }
    }
}
