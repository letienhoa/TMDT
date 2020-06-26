using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website_BanDienThoai_Version1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Website_BanDienThoai_Version1.Extentions;
namespace Website_BanDienThoai_Version1.Controllers
{
    [Area("Customer")]
    public class PhoneController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PhoneController(ApplicationDbContext db)
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