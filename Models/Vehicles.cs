using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    
    public class Vehicles 
    { 
        public int NumberOfAxels { get; set; }
        public int Weight { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfPassengers { get; set; }
        public int Year { get; set; }

    }



}