﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {

        private JobDbContext _context;

        public EmployerController(JobDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/

        public IActionResult Index()
        {
            List<Employer> employers = _context.Employers.ToList();
            return View(employers);
        }

        public IActionResult Add()
        {
            AddEmployerViewModel add = new AddEmployerViewModel();
            return View(add);
        }

        [HttpPost]
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel add)
        {
            if (ModelState.IsValid)
            {
                Employer employer = new Employer
                {
                    Name = add.Name,
                    Location = add.Location
                        
                };
                _context.Employers.Add(employer);
                _context.SaveChanges();
                return Redirect("/Employer");
            }
            return View("Add", add);
            
        }

        public IActionResult About(int id)
        {
            Employer employer = _context.Employers.Find(id);
            
            return View(employer);
        }
    }
}
