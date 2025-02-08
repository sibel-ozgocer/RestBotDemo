using Domain.Common;

namespace RestBot.Domain.Entities;

/// <summary>
/// inheritence nedir ?
/// </summary>
public class Reservation : BaseEntity
{
    public string? CustomerName { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime ReservationDate { get; set; }
    public int NumberOfPeople { get; set; }
    public string? SpecialRequest { get; set; }
}