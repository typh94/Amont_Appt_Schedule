using System;
using Amont_APPT.Context;
using Amont_APPT.Models;
using Microsoft.AspNetCore.Mvc;

namespace Amont_APPT.Controllers
{
    public class FormController : Controller
    {


        private readonly Amont_APPTDbContext _context;

        public FormController(Amont_APPTDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Index([FromForm] string firstName, [FromForm]  string os, [FromForm] string lastName, 
                                   [FromForm] string phone, [FromForm] string email, [FromForm] string address,
                                   [FromForm] string city, [FromForm] string description, [FromForm] int zipcode )
        {
            var person = new FormModel
            {
                FirstName = firstName,
                OS = os,
                LastName = lastName,
                Phone = phone,
                Email = email,
                Address = address,
                City = city,
                Description = description,
                ZipCode = zipcode
            };
 
            _context.People.Add(person);
            _context.SaveChanges(); // Save to the database

            return Content($"Bonjour, {firstName} {lastName}! Vos informations ont bien ete enregistrees");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
 
    }
}
