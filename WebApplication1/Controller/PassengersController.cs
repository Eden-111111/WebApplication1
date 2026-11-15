using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        MyDataContext db= new MyDataContext();
        [HttpGet]
        public List<Passengers>GetAllPassengers()
        {
            return db.Passengers.ToList();
        }
        [HttpPost]
        public void AddPassengers(Passengers passengers)
        {
            db.Passengers.Add(passengers);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdatePassengers(Passengers A)
        {
            Passengers A2 = db.Passengers.FirstOrDefault(x => x.PassengerCode == A.PassengerCode);
            A2.FirstName = A.FirstName;
            A2.LastName = A.LastName;
            A2.PassportNumber = A.PassportNumber;
            A2.Status = A.Status;
            A2.PassengerId = A.PassengerId;
            db.Passengers.Update(A2);
            db.SaveChanges();
        }
        [HttpPut("deletePassengers")]
        public void DelPassengers(int id)
        {
            Passengers c2 = db.Passengers.FirstOrDefault(x => x.PassengerCode == id);
            c2.Status = false;
            db.Passengers.Update(c2);
            db.SaveChanges();
        }
       


    }
    }
