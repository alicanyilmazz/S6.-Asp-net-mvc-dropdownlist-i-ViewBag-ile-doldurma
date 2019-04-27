using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag_using.Models;

namespace ViewBag_using.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult homepage()
        {

            ViewBag.SelectedCityId = "Please choose City";
            ViewBag.SelectedCountryId = "Please choose Country";


            ViewBag.CitiesData = new SelectList(City.GetFakeCities(), "City_Id", "City_name"); //burdaki isimler sınıftaki property isimleri ile aynı olmalıdır.
            ViewBag.CountriesData = new SelectList(Country.GetFakeCountries(), "Country_Id", "Country_name");//burdaki isimler sınıftaki property isimleri ile aynı olmalıdır.

          

            return View();
        }

        [HttpPost]
        public ActionResult homepage(int SelectedCityId,int SelectedCountryId)
        {

            ViewBag.SelectedCityId = SelectedCityId;
            ViewBag.SelectedCountryId = SelectedCountryId;

            ViewBag.CitiesData = new SelectList(City.GetFakeCities(), "City_Id", "City_name"); //burdaki isimler sınıftaki property isimleri ile aynı olmalıdır.
            ViewBag.CountriesData = new SelectList(Country.GetFakeCountries(), "Country_Id", "Country_name");//burdaki isimler sınıftaki property isimleri ile aynı olmalıdır.


            return View();
        }

    }
}

/*
 dropdown da veriyi 2 farklı yolla gönderebilirsin,
 
    1. SelectList  şeklinde yada,
    2.  List<SelectListItem>  şeklinde.
  
    SelectList aslında veriyi tutan bir class ve dd bu veriyi 
    SelectList içerisinden alabilicek yapıya sahip.
*/

/*

NOTE: Diger kullanim yöntemi ise dogrudan atama yapmak istemiyorsak ViewBag 'e 


    SelectList SelectList_City = new SelectList(City.GetFakeCities(), "City_Id", "City_name"); //burdaki isimler sınıftaki property isimleri ile aynı olmalıdır.
           SelectList SelectList_Country = new SelectList(Country.GetFakeCountries(), "Country_Id", "Country_name");//burdaki isimler sınıftaki property isimleri ile aynı olmalıdır.

           ViewBag.CitiesData = SelectList_City;
           ViewBag.CountriesData = SelectList_Country;



    şeklinde olacaktır.
*/
