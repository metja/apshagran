using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NakaSiteMVC.Controllers
{
    public class MaterialGaleryController : Controller
    {
        public IActionResult UaStone()
        {
            return View();
        }

        public IActionResult ImpStone()
        {
            return View();
        }

        public IActionResult Marmur()
        {
            return View();
        }

        public IActionResult Kvarz()
        {
            return View();
        }
    }
}
