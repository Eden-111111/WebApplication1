using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        MyDataContext db=new MyDataContext();
        [HttpGet]
        public List<Flights> GetAllFlights()
        {
            return db.Flights.ToList();
        }
        [HttpPost]
        public void AddFlights(Flights flights)
        {
            db.Flights.Add(flights);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateFlights(Flights A)
        {
            Flights A2 = db.Flights.FirstOrDefault(x => x.FlightId == A.FlightId);
            A2.DepartureDate = A.DepartureDate;
            A2.DepartureTime = A.DepartureTime;
            A2.DepartureAirportId = A.DepartureAirportId;
            A2.Status = A.Status;
            A2.AircraftId = A.AircraftId;
            A2.ArrivalAirportId = A.ArrivalAirportId;
            A2.Status1 = A.Status1;
            db.Flights.Update(A2);
            db.SaveChanges();
        }
        [HttpPut("deleteFlights")]
        public void DelFlights(int id)
        {
            Flights c2 = db.Flights.FirstOrDefault(x => x.FlightId == id);
            c2.Status1 = false;
            db.Flights.Update(c2);
            db.SaveChanges();
        }


        }
    }
