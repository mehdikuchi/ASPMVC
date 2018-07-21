using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using app1.Models;

namespace app1.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return Content("Hello");
        }
        // GET: Customer
        public ActionResult Details(int id)
        {
            var Customer = GetCustomers().SingleOrDefault(h => h.Id == id);
            if (Customer == null)
            {
                return HttpNotFound();
            }
            return View(Customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Gender=1,Id=1,Name="Mehdi"},
                new Customer { Gender = 0 , Id = 2, Name = "Narges" }
            };
        }
    }
}