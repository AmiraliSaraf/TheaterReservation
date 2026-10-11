using TheaterReservation.MyWebApi.Interfaces;
using TheaterReservation.MyWebApi.Models;

namespace TheaterReservation.MyWebApi.Services;

public class ReservationService : IReservationService
{
    public int AddReservation(Reservation reservation)
    {
        // TODO: Validate performance and seats, then save through a database.
        // This fixed value is only a teaching placeholder, like the instructor's sample service.
        return 1;
    }
}
