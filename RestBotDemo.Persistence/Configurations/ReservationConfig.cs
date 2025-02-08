using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestBot.Domain.Entities;

namespace RestBotDemo.Persistence.Configurations;



public class ReservationConfig : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.ToTable("Reservations");


        builder.HasKey(x => x.Id);

        builder.Property(r => r.CustomerName)
            .IsRequired(false)
            .HasMaxLength(100);

        builder.Property(r => r.PhoneNumber)
            .IsRequired(false)
            .HasMaxLength(20);

        builder.Property(r => r.NumberOfPeople)
            .IsRequired();

        builder.Property(r => r.SpecialRequest)
        .IsRequired(false);

        builder.Property(r => r.ReservationDate)
            .IsRequired();
    }
}
