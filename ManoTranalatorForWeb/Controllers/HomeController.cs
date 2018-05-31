using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManoTranalatorForWeb.Models;

namespace ManoTranalatorForWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult About()2
        //{
        //    return View();
        //}

        public IActionResult About(ManoText manoText)
        {
            return View(manoText);
        }

        // POST: TextHolders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Convert(int id, [Bind("Id,InputText,OutputText")] ManoText manoText)
        {
            if (id != manoText.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var num = 0;
                var tmp = num + 5;
            }

            return RedirectToAction(nameof(About), new ManoText { Id = 5, InputText = "Hello!", OutputText = "World!" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deconvert(int id, [Bind("Id,InputText,OutputText")] ManoText manoText)
        {
            if (id != manoText.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var num = 0;
                var tmp = num + 5;
            }

            return RedirectToAction(nameof(About), new ManoText { Id = 5, InputText = "Hello!", OutputText = "World!" });
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
