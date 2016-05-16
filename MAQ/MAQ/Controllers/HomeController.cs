﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace MAQ.Controllers
{
    public class HomeController : Controller
    {
        //Get: Country
        public ActionResult Index()        
            {
            List<SelectListItem> GetCountryList = new List<SelectListItem>();
            GetCountryList.Add(new SelectListItem { Text = "Select", Value = "0" });
            GetCountryList.Add(new SelectListItem { Text = "India", Value = "1" });
            GetCountryList.Add(new SelectListItem { Text = "Srilanka", Value = "2" });
            GetCountryList.Add(new SelectListItem { Text = "China", Value = "3" });
            GetCountryList.Add(new SelectListItem { Text = "Austrila", Value = "4" });
            GetCountryList.Add(new SelectListItem { Text = "USA", Value = "5" });
            GetCountryList.Add(new SelectListItem { Text = "UK", Value = "6" });
            ViewData["country"] = GetCountryList;
            return View();
        }       

//Get:State
public JsonResult GetStates(string id)
{
    List<SelectListItem> states = new List<SelectListItem>();
    switch (id)
    {
        case "1":
            states.Add(new SelectListItem { Text = "Select", Value = "0" });
            states.Add(new SelectListItem { Text = "ANDAMAN & NIKOBAR ISLANDS", Value = "1" });
            states.Add(new SelectListItem { Text = "ANDHRA PRADESH", Value = "2" });
            states.Add(new SelectListItem { Text = "ARUNACHAL PRADESH", Value = "3" });
            states.Add(new SelectListItem { Text = "ASSAM", Value = "4" });
            states.Add(new SelectListItem { Text = "BIHAR", Value = "5" });
            states.Add(new SelectListItem { Text = "CHANDIGARH", Value = "6" });
            states.Add(new SelectListItem { Text = "CHHATTISGARH", Value = "7" });
            states.Add(new SelectListItem { Text = "DADRA & NAGAR HAVELI", Value = "8" });
            states.Add(new SelectListItem { Text = "DAMAN & DIU", Value = "9" });
            states.Add(new SelectListItem { Text = "GOA", Value = "10" });
            states.Add(new SelectListItem { Text = "GUJARAT", Value = "11" });
            states.Add(new SelectListItem { Text = "HARYANA", Value = "12" });
            states.Add(new SelectListItem { Text = "HIMACHAL PRADESH", Value = "13" });
            states.Add(new SelectListItem { Text = "JAMMU & KASHMIR", Value = "14" });
            states.Add(new SelectListItem { Text = "JHARKHAND", Value = "15" });
            states.Add(new SelectListItem { Text = "KARNATAKA", Value = "16" });
            states.Add(new SelectListItem { Text = "KERALA", Value = "17" });
            states.Add(new SelectListItem { Text = "LAKSHADWEEP", Value = "18" });
            states.Add(new SelectListItem { Text = "MADHYA PRADESH", Value = "19" });
            states.Add(new SelectListItem { Text = "MAHARASHTRA", Value = "20" });
            states.Add(new SelectListItem { Text = "MANIPUR", Value = "21" });
            states.Add(new SelectListItem { Text = "MEGHALAYA", Value = "22" });
            states.Add(new SelectListItem { Text = "MIZORAM", Value = "23" });
            states.Add(new SelectListItem { Text = "NAGALAND", Value = "24" });
            states.Add(new SelectListItem { Text = "NCT OF DELHI", Value = "25" });
            states.Add(new SelectListItem { Text = "ORISSA", Value = "26" });
            states.Add(new SelectListItem { Text = "PUDUCHERRY", Value = "27" });
            states.Add(new SelectListItem { Text = "PUNJAB", Value = "28" });
            states.Add(new SelectListItem { Text = "RAJASTHAN", Value = "29" });
            states.Add(new SelectListItem { Text = "SIKKIM", Value = "30" });
            states.Add(new SelectListItem { Text = "TAMIL NADU", Value = "31" });
            states.Add(new SelectListItem { Text = "TRIPURA", Value = "32" });
            states.Add(new SelectListItem { Text = "UTTAR PRADESH", Value = "33" });
            states.Add(new SelectListItem { Text = "UTTARAKHAND", Value = "34" });
            states.Add(new SelectListItem { Text = "WEST BENGAL", Value = "35" });
            break;
        case "2":
            states.Add(new SelectListItem { Text = "Select", Value = "0" });
            states.Add(new SelectListItem { Text = "Central", Value = "1" });
            states.Add(new SelectListItem { Text = "Eastern", Value = "2" });
            states.Add(new SelectListItem { Text = "North Central", Value = "3" });
            states.Add(new SelectListItem { Text = "Northern", Value = "4" });
            states.Add(new SelectListItem { Text = "North Western", Value = "5" });
            states.Add(new SelectListItem { Text = "Sabaragamuwa", Value = "6" });
            states.Add(new SelectListItem { Text = "Southern", Value = "7" });
            states.Add(new SelectListItem { Text = "Uva", Value = "8" });
            states.Add(new SelectListItem { Text = "Western", Value = "9" });
            break;
        case "3":
            states.Add(new SelectListItem { Text = "Select", Value = "0" });
            states.Add(new SelectListItem { Text = "Beijing Municipality", Value = "1" });
            states.Add(new SelectListItem { Text = "Tianjin Municipality", Value = "2" });
            states.Add(new SelectListItem { Text = "Hebei Province", Value = "3" });
            states.Add(new SelectListItem { Text = "Shanxi Province", Value = "4" });
            states.Add(new SelectListItem { Text = "Inner Mongolia Autonomous Region", Value = "5" });
            states.Add(new SelectListItem { Text = "Liaoning Province", Value = "6" });
            states.Add(new SelectListItem { Text = "Heilongjiang Province", Value = "7" });
            states.Add(new SelectListItem { Text = "Jilin Province", Value = "7" });
            states.Add(new SelectListItem { Text = "Shanghai Municipality", Value = "8" });
            states.Add(new SelectListItem { Text = "Jiangsu Province", Value = "9" });
            break;

    }
    return Json(new SelectList(states, "Value", "Text"));
}
    }
}