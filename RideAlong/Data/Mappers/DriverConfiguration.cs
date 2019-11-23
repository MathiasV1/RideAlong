using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideAlong.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Data.Mappers
{
    public class DriverConfiguration: IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.ToTable("Driver");
            builder.Property(d => d.Naam).IsRequired();
            builder.Property(d => d.Voornaam).IsRequired();
            builder.Property(d => d.TelefoonNummer).IsRequired();
            builder.HasKey("DriverId");

        }
    }
}
