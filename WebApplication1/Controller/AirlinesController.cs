using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlinesController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<Airlines> GetAllAirlines()
        {
            return db.Airlines.ToList();
        }

        [HttpPost]
        public void AddAirline(Airlines airline)
        {
            db.Airlines.Add(airline);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateAirline(Airlines A)
        {
            Airlines A2 = db.Airlines.FirstOrDefault(x => x.AirlineId == A.AirlineId);
            A2.AirlineName = A.AirlineName;
            A2.Country = A.Country;
            A2.Status = A.Status;
            db.Airlines.Update(A2);
            db.SaveChanges();
        }
        [HttpPut("deleteAirlines")]
        public void DelAirlines(int id)
        {
            Airlines c2 = db.Airlines.FirstOrDefault(x => x.AirlineId == id);
            c2.Status = false;
            db.Airlines.Update(c2);
            db.SaveChanges();

        }
    }
}
