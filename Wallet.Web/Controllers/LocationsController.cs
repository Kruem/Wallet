using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallet.Web.Data;

namespace Wallet.Web.Controllers
{
    public class LocationsController : Controller
    {
        private readonly DataContext _context;

        public LocationsController(DataContext context)
        {
            _context = context;
        }
    }
}
