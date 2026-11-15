using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaggageController : ControllerBase
    {
        MyDataContext db=new MyDataContext();
        [HttpGet]
        public List<Baggage> GetAllBaggage()
        {
            return db.Baggage. ToList(); 

        }
        [HttpPost]
        public void AddBaggage(Baggage baggage)
        {
            db.Baggage.Add(baggage);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateBaggage(Baggage A)
        {
            Baggage A2 = db.Baggage.FirstOrDefault(x => x.BaggageId == A.BaggageId);
            A2.BaggageTag = A.BaggageTag;
            A2.BaggageType = A.BaggageType;
            A2.BookingId = A.BookingId;
            A2.Weight = A.Weight;
            A2.Status = A.Status;
            A2.Status1 = A.Status1;
            db.Baggage.Update(A2);
            db.SaveChanges();
        }
        [HttpPut("deleteBaggage")]
        public void DelBaggage(int id)
        {
            Baggage c2 = db.Baggage.FirstOrDefault(x => x.BaggageId == id);
            c2.Status1 = false;
            db.Baggage.Update(c2);
            db.SaveChanges();
        }


        }
    }
