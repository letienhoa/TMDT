using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Website_BanDienThoai_Version1.Data;

namespace Website_BanDienThoai_Version1.Areas.Admin.Controllers
{
    public class DondathangtController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DondathangtController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var dondathang = _db.ProductSelectedForAppointment.FromSql("EXECUTE DBO.Select_All_Dondathang");
            
            return View();
        }
    }
}