using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideAlong.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Data.Mappers
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.ToTable("Passenger");
            builder.HasKey("PassengerId");
            builder.Property(p => p.Naam).IsRequired();
            builder.Property(p => p.Voornaam).IsRequired();
            builder.Property(p => p.TelefoonNummer).IsRequired();
            builder.Property(p => p.Subscription).IsRequired();
        }
    }
}
