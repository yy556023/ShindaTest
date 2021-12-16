using Microsoft.AspNetCore.Mvc;
using ShinTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ShinTest.Controllers
{
    public class ShindaController : Controller
    {
        private readonly ShindaTestContext _context;

        public ShindaController(ShindaTestContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.TblActiveItem.ToList();

            return View(data);
        }

        public IActionResult Create()
        {
            var data = _context.TblActiveItem.ToList();

            return View(data);
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult CreatePost()
        {
            var data = _context.TblActiveItem.ToList();

            return View(data);
        }
    }
}
