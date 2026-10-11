using Microsoft.AspNetCore.Mvc;
using TheaterReservation.MyWebApi.Dtos;
using TheaterReservation.MyWebApi.Interfaces;
using TheaterReservation.MyWebApi.Models;

namespace TheaterReservation.MyWebApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ReservationController : ControllerBase
{
    private readonly IReservationService _reservationService;

    public ReservationController(IReservationService reservationService)
    {
        _reservationService = reservationService;
    }

    [HttpPost]
    public IActionResult Add([FromBody] AddReservationRequest dto)
    {
        // Map the public request DTO to the application's reservation model.
        var reservation = new Reservation
        {
            PerformanceId = dto.PerformanceId,
            CustomerName = dto.CustomerName,
            SeatIds = dto.SeatIds,
            CreatedAt = DateTime.UtcNow
        };

        int result = _reservationService.AddReservation(reservation);
        return Ok(new AddReservationResponse { Id = result });
    }

    [HttpPut]
    public IActionResult Update(int id, [FromBody] AddReservationRequest dto)
    {
        // Placeholder endpoint, matching the lesson's controller example.
        return Ok("Update reservation is not implemented yet.");
    }

    [HttpGet]
    public IActionResult GetById(int id)
    {
        // Placeholder endpoint, matching the lesson's controller example.
        return Ok("Reservation lookup is not implemented yet.");
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        // Placeholder endpoint, matching the lesson's controller example.
        return Ok("Reservation listing is not implemented yet.");
    }
}
