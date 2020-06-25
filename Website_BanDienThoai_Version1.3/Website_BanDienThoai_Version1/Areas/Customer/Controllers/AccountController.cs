using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Website_BanDienThoai_Version1.Data;

using Website_BanDienThoai_Version1.Models;
using Website_BanDienThoai_Version1.Models.ViewModel;

namespace Website_BanDienThoai_Version1.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;
        [TempData]
        public string StatusMessage { get; set; }

        public AccountController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        // vào giao diện khi chuyển trang login
        public IActionResult Login()
        {
            return View();
        }


        //nhấn button để xác thực
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var log = _db.Users.FromSql("EXECUTE [dbo].[User_Login] {0},{1}", model.UserName, model.Password).FirstOrDefault();
             
                if (log==null)
                {
                    TempData["StatusMessage"] = "Tài khoản hoặc mật khẩu bị sai!!!";

                    return View(model);
                }
                else
                {
                    if (model.UserName == "admin")
                      {
                        HttpContext.Session.SetInt32("AccountId", log.Id);
                        return RedirectToAction("Index", "Products", new { area = "Admin" });
                      }

                    HttpContext.Session.SetInt32("AccountId", log.Id);
                    
                    return RedirectToAction("Index", "Home", new { area = "Customer" });
                }
            }
            return View("Index");
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        //lưu lại xuống data
        public async Task<ActionResult> Register(RegistrationViewModel model)
        {
            if(ModelState.IsValid)
            {
                _db.Database.ExecuteSqlCommand("EXECUTE DBO.Insert_Users {0},{1},{2},{3},{4},{5},{6}",
                   model.UserName,model.Password,model.Name,model.Email,model.Phone,model.DateOfBith, Int32.Parse(model.Gender));

                await _db.SaveChangesAsync();
                return RedirectToAction("Index", "Account");
            }
            return View(model);
        
                
          
          
        }
        [HttpGet]
        //thay vì return view tức thì, thì sẽ return view theo một đường dẫn tới
        public IActionResult Logout()
        {
            int value = -1;
            HttpContext.Session.SetInt32("AccountId",value);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AccountUser()
        {
            
            var Id = HttpContext.Session.GetInt32("AccountId");
            var AccUser = _db.Users.Find(Id);
            if(AccUser==null)
            {
                return RedirectToAction("Login", "Account");
            }
            ViewBag.Id = AccUser.Id;
            ViewBag.Name = AccUser.Name;
            ViewBag.Username = AccUser.UserName;
            ViewBag.Password = AccUser.Password;
            ViewBag.Email = AccUser.Email;
            ViewBag.Phone = AccUser.Phone;
            ViewBag.DateOfBirth = AccUser.DateOfBith;
            if(AccUser.Gender==1)
            {
                ViewBag.Gender = "Nam";
            }
            else
            {
                ViewBag.Gender = "Nữ";
            }


            return View();
        }
        //Get: Change Account
        public async Task<IActionResult> ChangeAccount(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await _db.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        //Post: Change Account
        [HttpPost,ActionName("ChangeAccount")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeAccountPost(int id, Users user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Database.ExecuteSqlCommand("EXECUTE DBO.Update_User {0},{1},{2},{3},{4},{5},{6},{7}", id,
                 user.UserName, user.Password, user.Name, user.Email, user.Phone, user.DateOfBith, user.Gender);
               // _db.Entry(user).Reload();
                await _db.SaveChangesAsync();
                //_db.Update(user);
                //await _db.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }
            return View(user);
        }
      
        /// <summary>
        /// Get: FogetPassword
        /// </summary>
        
        public IActionResult FogetPassword()
        {
            return View();
        }
      
        public void ValidationMessage(string key, string alert, string value)
        {
            try
            {
                TempData.Remove(key);
                TempData.Add(key, value);
                TempData.Add("alertType", alert);
            }
            catch
            {
                Debug.WriteLine("TempDataMessage Error");
            }
        }

    }
}