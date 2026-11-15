using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AircraftController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<Aircraft> GetAllAircraft()
        {
            return db.Aircraft.ToList();

        }
        [HttpPost]
        public void AddAircraft(Aircraft aircraft)
        {
            db.Aircraft.Add(aircraft);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateAircraft(Aircraft A)
        {
            Aircraft A2 = db.Aircraft.FirstOrDefault(x => x.AircraftId == A.AircraftId);
            A2.AirlineId = A.AirlineId;
            A2.Model = A.Model;
            A2.SeatCapacity = A.SeatCapacity;
            A2.Status = A.Status;
            db.Aircraft.Update(A2);
            db.SaveChanges();
        }
        [HttpPut("deleteAircraft")]
        public void DelAircraft(int id)
        {
            Aircraft c2 = db.Aircraft.FirstOrDefault(x => x.AircraftId == id);
            c2.Status = false;
            db.Aircraft.Update(c2);
            db.SaveChanges();
        }
    }
}


