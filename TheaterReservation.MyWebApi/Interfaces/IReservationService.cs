using TheaterReservation.MyWebApi.Models;

namespace TheaterReservation.MyWebApi.Interfaces;

public interface IReservationService
{
    int AddReservation(Reservation reservation);
}
