using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using DemoAPI.Models;
namespace DemoAPI.Controllers
{
   [EnableCors("*", "*","*")]
    public class EmpsController : ApiController
    {
        PuneDBEntities db = new PuneDBEntities();
        // GET: api/Emps
        public IEnumerable<Emp> Get()
        {
            return db.Emps.ToList();
        }

        // GET: api/Emps/5
        public Emp Get(int id)
        {
            return db.Emps.Find(id);
        }

        // POST: api/Emps
        public void Post([FromBody]Emp emp)
        {
            db.Emps.Add(emp);
            db.SaveChanges();
        }

        // PUT: api/Emps/5
        public void Put(int id, [FromBody] Emp emp)
        {
            Emp empToBeUpdated = db.Emps.Find(id);
            empToBeUpdated.Name = emp.Name;
            empToBeUpdated.Address = emp.Address;
            db.SaveChanges();
        }

        // DELETE: api/Emps/5
        public void Delete(int id)
        {
            Emp empToBeDeleted = db.Emps.Find(id);
            db.Emps.Remove(empToBeDeleted);
            db.SaveChanges();
        }
    }
}
