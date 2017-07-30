using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("Customers/Index")]
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        //GET: Customer/Details/id
        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            foreach (Customer cust in GetCustomers())
            {
                if (cust.Id == id)
                {
                    return View(cust);
                }
            }
            return HttpNotFound();
        }

        private IEnumerable<Customer> GetCustomers()
        {
            //Create and return a list of customers
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith"},
                new Customer { Id = 2, Name = "Mary Williams"}
            };
        }
    }
}