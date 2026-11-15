using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerminalsController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<Terminals> GetAllTerminals()
        {
            return db.Terminals.ToList();
        }
        [HttpPost]
        public void AddTerminals(Terminals terminals)
        {
            db.Terminals.Add(terminals);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateTerminals(Terminals A)
        {
            Terminals A2 = db.Terminals.FirstOrDefault(x => x.TerminalId == A.TerminalId);
            A2.AirportId = A.AirportId;
            A2.Status = A.Status;
            db.Terminals.Update(A2);
            db.SaveChanges();
        }
        [HttpPut("deleteTerminal")]
        public void DelTerminal(int id)
        {
            Terminals c2 = db.Terminals.FirstOrDefault(x => x.TerminalId == id);
            c2.Status = false;
            db.Terminals.Update(c2);
            db.SaveChanges();
        }
        [HttpDelete]
        public void DeleteTerminals(int T)
        {
            Terminals T2 = db.Terminals.FirstOrDefault(x => x.TerminalId ==T );
            db.Terminals.Remove(T2);
            db.SaveChanges();
        }




    }
}
