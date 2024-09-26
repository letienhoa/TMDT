using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Website_BanDienThoai_Version1.Data;

namespace Website_BanDienThoai_Version1.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class LinhKienController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LinhKienController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var productList = await _db.Products.Include(m => m.Category).Include(m => m.SpecialTag).ToListAsync();
            return View(productList);

        }
    }
}