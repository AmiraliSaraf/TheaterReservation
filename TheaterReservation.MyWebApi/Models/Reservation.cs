namespace TheaterReservation.MyWebApi.Models;

/// <summary>Represents a customer's reservation for a theater performance.</summary>
public class Reservation
{
    public int Id { get; set; }
    public int PerformanceId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public List<int> SeatIds { get; set; } = [];
    public DateTime CreatedAt { get; set; }
}
