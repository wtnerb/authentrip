using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace country_info.Controllers
{
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        // GET api/values
        [HttpGet("{Country}")]
        public Country Get(string iso)
        {
            return new Country();
        }


        [HttpGet("{lat}/{long}")]
        public IEnumerable<Atm> Get(double lat, double lon)
        {
            return new List<Atm> {
                new Atm( "US bank ATM", 50.40001, 50.2222),
                new Atm( "Bank of America ATM", 49.40001, 10.2222),
                new Atm( "Chase Bank", 25.40001, 5.2222)
            };
        }

    }

    public struct Atm {
        public Atm (string name, double latitude, double longitude){
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }
        public string Name;
        public double Latitude;
        public double Longitude;
    }

    public struct Country {
        public Country (string iso)
    {
        Exchange = 1.33215;
        TipAmount = new Dictionary<string, int> () {
            {"dining", 15 },
            {"porter", 10}
        };
    }
        public double Exchange;
        public Dictionary<string, int> TipAmount;

    }
}
