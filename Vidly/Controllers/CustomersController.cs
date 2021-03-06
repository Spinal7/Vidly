﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        //DBContext to access the database
        private ApplicationDbContext _context;

        public CustomersController()
        {
            //Initialization of DBContext
            _context = new ApplicationDbContext();
        }

        //DBContext is a Disposable object. Need to override the Dispose method from the base controller class
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        [Route("Customers/Index")]
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        //GET: Customer/Details/id
        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            //Iterate through the list of Customers returned from the Customers table from the database
            foreach (Customer cust in _context.Customers.Include(c => c.MembershipType).ToList())
            {
                if (cust.Id == id)
                {
                    return View(cust);
                }
            }
            return HttpNotFound();
        }
        
    }
}