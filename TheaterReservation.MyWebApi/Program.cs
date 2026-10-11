using TheaterReservation.MyWebApi.Interfaces;
using TheaterReservation.MyWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Register MVC controllers and API documentation.
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency Injection: when a controller asks for the interface,
// create a ReservationService for this HTTP request.
builder.Services.AddScoped<IReservationService, ReservationService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
