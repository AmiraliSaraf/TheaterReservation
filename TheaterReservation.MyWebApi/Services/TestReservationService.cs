using TheaterReservation.MyWebApi.Interfaces;
using TheaterReservation.MyWebApi.Models;

namespace TheaterReservation.MyWebApi.Services;

/// <summary>Sample alternative implementation for learning or later testing.</summary>
public class TestReservationService : IReservationService
{
    public int AddReservation(Reservation reservation)
    {
        // A test implementation could store data in memory; currently it returns a sample ID.
        return 1;
    }
}
