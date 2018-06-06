using ManoTranslatorCLI;
using ManoTranslatorForWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace ManoTranslatorForWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(ManoText manoText)
        {
            return View(manoText);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Convert(string id, [Bind("Id,InputText,OutputText")] ManoText manoText)
        {
            var inputText = string.Empty;
            var outputText = string.Empty;
            if (id != manoText.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                inputText = manoText.InputText;
                var translator = new Translator();
                outputText = translator.Encode(manoText.InputText ?? string.Empty);
            }

            return RedirectToAction(nameof(Index), new ManoText { Id = Guid.NewGuid().ToString(), InputText = inputText, OutputText = outputText });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deconvert(string id, [Bind("Id,InputText,OutputText")] ManoText manoText)
        {
            var inputText = string.Empty;
            var outputText = string.Empty;
            if (id != manoText.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                inputText = manoText.InputText;
                var translator = new Translator();
                outputText = translator.Decode(manoText.InputText ?? string.Empty);
            }

            return RedirectToAction(nameof(Index), new ManoText { Id = Guid.NewGuid().ToString(), InputText = inputText, OutputText = outputText });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
