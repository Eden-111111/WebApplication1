using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportsController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<Airports> GetAllAirlines()
        {
            return db.Airports.ToList();
        }
        [HttpGet("ByRegion")]
        public List<Airports> GetAirportsByRegion(string region)
        {
            return db.Airports.Where(x => x.Region == region).ToList();
        }
        [HttpGet("ByCountry")]
        public List<Airports> GetAirportsByCountry(string country)
        {
            return db.Airports.Where(x => x.Country == country).ToList();
        }
        [HttpPost]
        public void AddAirport(Airports airport)
        {
            db.Airports.Add(airport);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateAirports(Airports A)
        {
            Airports A2 = db.Airports.FirstOrDefault(x => x.AirportId == A.AirportId);
            A2.AirportName = A.AirportName;
            A2.Country = A.Country;
            A2.Region = A.Region;
            A2.Longitude = A.Longitude;
            A2.Latitude = A.Latitude;
            A2.Status = A.Status;
            A2.City = A.City;
            db.Airports.Update(A2);
            db.SaveChanges();
        }
        [HttpPut("deleteAirports")]
        public void DelAirports(int id)
        {
            Airports c2 = db.Airports.FirstOrDefault(x => x.AirportId == id);
            c2.Status = false;
            db.Airports.Update(c2);
            db.SaveChanges();
        }
    }

}
