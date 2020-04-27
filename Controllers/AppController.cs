using LoanWebApp.Services;
using LoanWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanWebApp.Controllers
{
    public class AppController: Controller
    {
        private readonly IMailService mailService;

        public AppController(IMailService mailService)
        {
            this.mailService = mailService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("intrebari")]
        public IActionResult Intrebari()
        {
            ViewBag.Title = "Intrebari frecvente";
            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //send email
                this.mailService.SendMessage("cezar@gmail.com", model.Email, $"From: {model.Nume} - {model.Prenume}, Message: {model.Mesaj}");
                ViewBag.UserMessage = "Cerere Trimisa";
                ModelState.Clear();
            }
            else
            {
                //send error
            }
            return View();
        }
    }
}