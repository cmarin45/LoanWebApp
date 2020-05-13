using LoanWebApp.Data;
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
        private readonly IMailService _mailService;
        private readonly LoanContext _ctx;

        public AppController(IMailService mailService, LoanContext ctx)
        {
            _mailService = mailService;
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            var results = _ctx.Products.ToList();
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
                _mailService.SendMessage("cezar@gmail.com", model.Email, $"From: {model.Nume} - {model.Prenume}, Message: {model.Mesaj}");
                ViewBag.UserMessage = "Cerere Trimisa";
                ModelState.Clear();
            }
            return View();
        }
        public IActionResult Shop()
        {
            var results = _ctx.Products
                .OrderBy(p => p.An)
                .ToList();
            return View();
        }
    }
}