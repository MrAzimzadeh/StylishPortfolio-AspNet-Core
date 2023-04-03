using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.ViewModel
{
    public class HomeVM
    {
        public Header Headers { get; set; }
        public About About { get; set; }
        public List<Services> Services { get; set; }

        public List<Portfolio> Portfolios { get; set; }

    }
}