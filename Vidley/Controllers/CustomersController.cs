using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidley.Models;
using Vidley.ViewModels;


namespace Vidley.Controllers
{
    public class CustomersController : Controller
    {

        public ViewResult Customer()
        {

               var customers = GetCustomers();
           
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id==id );

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }


        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {

                new Customer { Name = "Karanbir Janjua"},
                new Customer { Name = "Jaikirat Sandhu" }

            };
        }
    }
}