using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/values1")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("home")]
        public ActionResult<int> Home()
        {

            List<string> values = new List<string>();
            values.Add("Suck yourself and");
            values.Add("fuck yourself and more");
            values.Add("Suck yourself and");
            values.Add("Suck yourself and");

            return values.Distinct().Count();
        }
   

        // GET api/values
        [HttpGet("car")]
        public ActionResult<Automobiles> GetCars()
        {
            Automobiles myVehicles = new Automobiles();
            myVehicles.Make = "Kia";
            myVehicles.Model = "Optima";
            myVehicles.Year = 2015;
            myVehicles.NumberOfAxels = 2;
            myVehicles.NumberOfPassengers = 5;
            myVehicles.Weight = 50;
            myVehicles.Color = "black";
            myVehicles.RideHigh = 6;
               

            return myVehicles;
        }


        // GET api/values
        [HttpGet("{carToSearch}")]
        public ActionResult<Automobiles> GetCars(string carToSearch)
        {
            List<Automobiles> autos = new List<Automobiles>();

            Automobiles myVehicles = new Automobiles();
            myVehicles.Make = "Kia";
            myVehicles.Model = "Optima";
            myVehicles.Year = 2015;
            myVehicles.NumberOfAxels = 2;
            myVehicles.NumberOfPassengers = 5;
            myVehicles.Weight = 50;
            myVehicles.Color = "black";
            myVehicles.RideHigh = 6;
            autos.Add(myVehicles);

            Automobiles myVehicles1 = new Automobiles();
            myVehicles1.Make = "Kia";
            myVehicles1.Model = "Sorrento";
            myVehicles1.Year = 2013;
            myVehicles1.NumberOfAxels = 2;
            myVehicles1.NumberOfPassengers = 8;
            myVehicles1.Weight = 50;
            myVehicles1.Color = "Green";
            myVehicles1.RideHigh = 50;
            autos.Add(myVehicles1);

            //seach list of vehicles based on string passed in
            
            return autos.Where(a => a.Model.Contains(carToSearch)).FirstOrDefault();;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
