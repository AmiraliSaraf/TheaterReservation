namespace TheaterReservation.MyWebApi.Dtos;

/// <summary>Client input required to request a reservation.</summary>
public class AddReservationRequest
{
    public int PerformanceId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public List<int> SeatIds { get; set; } = [];
}
