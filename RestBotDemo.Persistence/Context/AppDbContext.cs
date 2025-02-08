using Microsoft.EntityFrameworkCore;
using RestBot.Domain.Entities;
using RestBotDemo.Persistence.Configurations;

namespace Persistence.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    public DbSet<Reservation> Reservations { get; set; }

    // rezervationconfig class ını burda tanımladık.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ReservationConfig());
    }
}

