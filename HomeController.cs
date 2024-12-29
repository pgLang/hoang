using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ThuVienOnline.Models;

namespace ThuVienOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly ThuVienOnLineContext _context;

        public HomeController(ThuVienOnLineContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
