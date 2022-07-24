using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NakaSiteMVC.Controllers
{
    public class ProductGaleryController : Controller
    {
        public IActionResult Pidvikonniki()
        {
            return View();
        }

        public IActionResult Parkany()
        {
            return View();
        }
        
        public IActionResult Garadychi()
        {
            return View();
        }      
        
        public IActionResult Stilnici()
        {
            return View();
        }  
        
        public IActionResult Dvory()
        {
            return View();
        }     
        
        public IActionResult Tables()
        {
            return View();
        }        
        public IActionResult Fundamenty()
        {
            return View();
        }
    }
}
