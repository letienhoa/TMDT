using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website_BanDienThoai_Version1.Models.ViewModel;
using Website_BanDienThoai_Version1.Data;
using Microsoft.AspNetCore.Http;
using Website_BanDienThoai_Version1.Extentions;
using Website_BanDienThoai_Version1.Models;
using Microsoft.EntityFrameworkCore;

namespace Website_BanDienThoai_Version1.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public ShoppingCartViewModel ShoppingCartVM { get; set; }
        public ShoppingCartController(ApplicationDbContext db)
        {
            _db = db;
            ShoppingCartVM = new ShoppingCartViewModel()
            {
                Products = new List<Models.Products>(),
                Appointments=new Appointments()
               
            };
        }

        static int total = 0;
        //Get Index Shopping Cart
        public async Task<IActionResult> Index()
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            var AccountId = HttpContext.Session.GetInt32("AccountId");
            if (lstShoppingCart != null && lstShoppingCart.Count > 0)
            {
                foreach (var cardItem in lstShoppingCart)
                {
                    Products product = _db.Products
                        .Include(p=>p.SpecialTag)
                        .Include(p=>p.Category)
                        .Where(p => p.Id == cardItem)
                        .FirstOrDefault();
                    ShoppingCartVM.Products.Add(product);
                    total = total + product.Price;
                }
                if (AccountId != null)
                {
                    Users user = _db.Users.Find(AccountId);
                    ShoppingCartVM.Appointments.CustomerEmail = user.Email;
                    ShoppingCartVM.Appointments.CustomerName = user.Name;
                    ShoppingCartVM.Appointments.CustomerPhoneNumber = user.Phone;
                }
            }
            return View(ShoppingCartVM);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Index")]
        public IActionResult IndexPost()
        {
            List<int> lstCartItems = HttpContext.Session.Get<List<int>>("ssShoppingCart");

            Appointments appointments = ShoppingCartVM.Appointments;
            appointments.BillDate = DateTime.Now;
            appointments.TotalPrice = total;
            total = 0;
            _db.Appointments.Add(appointments);
            _db.SaveChanges();

            int appointmentId = appointments.Id;

            foreach (int productId in lstCartItems)
            {
                ProductSelectedForAppointment ProductSelectedForAppointment = new ProductSelectedForAppointment()
                {
                    AppointmentId = appointmentId,
                    ProductId = productId
                };
                _db.ProductSelectedForAppointment.Add(ProductSelectedForAppointment);

            }
            _db.SaveChanges();
            lstCartItems = new List<int>();
            HttpContext.Session.Set("ssShoppingCart", lstCartItems);

            return RedirectToAction("AppointmentConfirmation", "ShoppingCart", new { Id = appointmentId });

        }


        public IActionResult Remove(int Id)
        {
            List<int> lstCartItems = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            if (lstCartItems.Count > 0)
            {
                if (lstCartItems.Contains(Id))
                {
                    lstCartItems.Remove(Id);
                }
            }
            HttpContext.Session.Set("ssShoppingCart", lstCartItems);
            return RedirectToAction(nameof(Index));

        }
        //Get
        public IActionResult AppointmentConfirmation(int id)
        {
            ShoppingCartVM.Appointments = _db.Appointments.Where(a => a.Id == id).FirstOrDefault();
            List<ProductSelectedForAppointment> objProdList = _db.ProductSelectedForAppointment.Where(p => p.AppointmentId == id).ToList();

            foreach (ProductSelectedForAppointment prodAptObj in objProdList)
            {
                ShoppingCartVM.Products.Add(_db.Products.Include(p => p.Category).Include(p => p.SpecialTag).Where(p => p.Id == prodAptObj.ProductId).FirstOrDefault());
            }

            return View(ShoppingCartVM);
        }

    }
}