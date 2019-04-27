 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewBag_using.Models
{
    public class Country
    {
        public int Country_Id { get; set; }
        public string Country_name { get; set; }

        public static List<Country> GetFakeCountries()  //metodumuz liste şeklinde değer döndürür hatta Country sınıfı tipinden Liste doner.
        {
            return new List<Country>()
            {
                new Country(){Country_Id=0,Country_name="Morocco"},
                 new Country(){Country_Id=1,Country_name="America"},
                  new Country(){Country_Id=2,Country_name="Holland"},
                   new Country(){Country_Id=3,Country_name="Germany"},
                    new Country(){Country_Id=4,Country_name="Russia"},

            };
        }
    }
}