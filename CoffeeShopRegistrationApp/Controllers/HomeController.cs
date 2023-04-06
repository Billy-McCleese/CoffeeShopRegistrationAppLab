﻿using CoffeeShopRegistrationApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace CoffeeShopRegistrationApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.States = new List<SelectListItem>
    {
                new SelectListItem { Value = "AL", Text = "Alabama" },
                        new SelectListItem { Value = "AK", Text = "Alaska" },
                        new SelectListItem { Value = "AZ", Text = "Arizona" },
                        new SelectListItem { Value = "AR", Text = "Arkansas" },
                        new SelectListItem { Value = "CA", Text = "California" },
                        new SelectListItem { Value = "CO", Text = "Colorado" },
                        new SelectListItem { Value = "CT", Text = "Connecticut" },
                        new SelectListItem { Value = "DE", Text = "Delaware" },
                        new SelectListItem { Value = "FL", Text = "Florida" },
                        new SelectListItem { Value = "GA", Text = "Georgia" },
                        new SelectListItem { Value = "HI", Text = "Hawaii" },
                        new SelectListItem { Value = "ID", Text = "Idaho" },
                        new SelectListItem { Value = "IL", Text = "Illinois" },
                        new SelectListItem { Value = "IN", Text = "Indiana" },
                        new SelectListItem { Value = "IA", Text = "Iowa" },
                        new SelectListItem { Value = "KS", Text = "Kansas" },
                        new SelectListItem { Value = "KY", Text = "Kentucky" },
                        new SelectListItem { Value = "LA", Text = "Louisiana" },
                        new SelectListItem { Value = "ME", Text = "Maine" },
                        new SelectListItem { Value = "MD", Text = "Maryland" },
                        new SelectListItem { Value = "MA", Text = "Massachusetts" },
                        new SelectListItem { Value = "MI", Text = "Michigan" },
                        new SelectListItem { Value = "MN", Text = "Minnesota" },
                        new SelectListItem { Value = "MS", Text = "Mississippi" },
                        new SelectListItem { Value = "MO", Text = "Missouri" },
                        new SelectListItem { Value = "MT", Text = "Montana" },
                        new SelectListItem { Value = "NE", Text = "Nebraska" },
                        new SelectListItem { Value = "NV", Text = "Nevada" },
                        new SelectListItem { Value = "NH", Text = "New Hampshire" },
                        new SelectListItem { Value = "NJ", Text = "New Jersey" },
                        new SelectListItem { Value = "NM", Text = "New Mexico" },
                        new SelectListItem { Value = "NY", Text = "New York" },
                        new SelectListItem { Value = "NC", Text = "North Carolina" },
                        new SelectListItem { Value = "ND", Text = "North Dakota" },
                        new SelectListItem { Value = "OH", Text = "Ohio" },
                        new SelectListItem { Value = "OK", Text = "Oklahoma" },
                        new SelectListItem { Value = "OR", Text = "Oregon" },
                        new SelectListItem { Value = "PA", Text = "Pennsylvania" },
                        new SelectListItem { Value = "RI", Text = "Rhode Island" },
                        new SelectListItem { Value = "SC", Text = "South Carolina" },
                        new SelectListItem { Value = "SD", Text = "South Dakota" },
                        new SelectListItem { Value = "TN", Text = "Tennessee" },
                        new SelectListItem { Value = "TX", Text = "Texas" },
                        new SelectListItem { Value = "UT", Text = "Utah" },
                        new SelectListItem { Value = "VT", Text = "Vermont" },
                        new SelectListItem { Value = "VA", Text = "Virginia" }
    };
            return View();
        }
        public IActionResult HandleSubmit(UserProfile userProfile)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("ThankYou", userProfile);
        }
        public IActionResult ThankYou(UserProfile userProfile)
        {
            return View(userProfile);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }

}
    
