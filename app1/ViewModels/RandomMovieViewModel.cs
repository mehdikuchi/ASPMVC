using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using app1.Models;


namespace app1.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}