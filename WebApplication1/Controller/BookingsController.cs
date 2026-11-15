using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        MyDataContext db=new MyDataContext();
        [HttpGet]
        public List<Bookings> GetAllBookings()
        {
            return db.Bookings.ToList();
        }
        [HttpPost]
        public void AddBookings(Bookings bookings)
        {
            db.Bookings.Add(bookings);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateBookings(Bookings A)
        {
            Bookings A2 = db.Bookings.FirstOrDefault(x => x.BookingId == A.BookingId);
            A2.BookingDate = A.BookingDate;
            A2.BookingStatus = A.BookingStatus;
            A2.Status = A.Status;
            A2.BookingStatus = A.BookingStatus;
            A2.PassengerCode = A.PassengerCode;
            A2.TicketPrice = A.TicketPrice;
            A2.SeatId = A.SeatId;
            db.Bookings.Update(A2);
            db.SaveChanges();
        }
        [HttpPut("deleteBookings")]
        public void DelBookings(int id)
        {
            Bookings c2 = db.Bookings.FirstOrDefault(x => x.BookingId == id);
            c2.Status = false;
            db.Bookings.Update(c2);
            db.SaveChanges();
        }

        }
    }
