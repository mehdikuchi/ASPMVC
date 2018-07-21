using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using app1.Models;
using System.Data.Entity;

namespace app1.Controllers
{
    public class CustomerController : Controller
    {
        private DBmodel _context;
        public CustomerController()
        {
            _context = new DBmodel();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var viewdata = new ViewModels.RandomMovieViewModel();
            viewdata.Customers = _context.Customers.Include(c => c.MemberShipType).ToList();
            
            return View(viewdata);
        }
        // GET: Customer
        public ActionResult Details(int id)
        {
            var Customer = _context.Customers.SingleOrDefault(h => h.Id == id);
            if (Customer == null)
            {
                return HttpNotFound();
            }
            return View(Customer);
        }

        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer {Gender=1,Id=1,Name="Mehdi"},
        //        new Customer { Gender = 0 , Id = 2, Name = "Narges" }
        //    };
        //}
    }
}