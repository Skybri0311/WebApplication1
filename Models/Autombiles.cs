using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{

    public class Automobiles : Vehicles
    {
        public int RideHigh { get; set; }
        public string Color { get; set; }
    }



}