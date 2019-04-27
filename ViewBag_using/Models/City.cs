using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewBag_using.Models
{
    public class City
    {
        public int City_Id { get; set; }
        public string City_name { get; set; }
        public int Country_Id { get; set; }

        public static List<City> GetFakeCities()  //metodumuz liste şeklinde değer döndürür hatta City sınıfı tipinden Liste doner.
        {
            return new List<City>()
            {
                new City(){City_Id=11,City_name="Manchester",Country_Id=0},
                new City(){City_Id=12,City_name="Amsterdam",Country_Id=0},
                new City(){City_Id=13,City_name="Newyork",Country_Id=1},
                new City(){City_Id=14,City_name="Utah",Country_Id=1},
                new City(){City_Id=15,City_name="Paris",Country_Id=2},
                new City(){City_Id=16,City_name="Budapeste",Country_Id=2},
                new City(){City_Id=17,City_name="Antioch",Country_Id=2},
                new City(){City_Id=18,City_name="Belgrad",Country_Id=3},
                new City(){City_Id=19,City_name="Oslo",Country_Id=4},
                new City(){City_Id=20,City_name="Tokyo",Country_Id=4}
                
            };
        }
    }
}