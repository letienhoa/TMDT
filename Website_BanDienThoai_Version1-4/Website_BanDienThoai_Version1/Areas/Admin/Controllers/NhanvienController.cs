using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using Website_BanDienThoai_Version1.Data;
using Website_BanDienThoai_Version1.Models;

namespace Website_BanDienThoai_Version1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NhanvienController : Controller
    {
        private readonly ApplicationDbContext _db;
        public NhanvienController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var nhanviens = _db.Nhanvien.FromSql("EXECUTE DBO.Select_All_nhanvien");

            return View(nhanviens);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Nhanvien user)
        {

            if (ModelState.IsValid)
            {
                _db.Database.ExecuteSqlCommand("EXECUTE DBO.Insert_nhanvien {0},{1},{2},{3},{4},{5},{6}",
                   user.UserName, user.Password, user.Name, user.Email, user.Phone, user.DateOfBith, user.Gender);

                await _db.SaveChangesAsync();

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Lê Hoà", "nhoxlexit1@gmail.com"));
                message.To.Add(new MailboxAddress("Từ admin", user.Email));
                message.Subject = "Thông tin tài khoản người dùng";
                message.Body = new TextPart("plain")
                {
                    Text = "Tài khoản để quý khách đăng nhập vào trang web là" + "\n" + "Tài khoản:" + user.UserName + "\n" + "Mật khẩu:" + user.Password + "\n"
                };
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("nhoxlexit1@gmail.com", "letienhoa");
                    client.Send(message);
                    client.Disconnect(true);
                }

                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await _db.Nhanvien.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Nhanvien user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {

                _db.Database.ExecuteSqlCommand("EXECUTE DBO.Update_nhanvien {0},{1},{2},{3},{4},{5},{6},{7}", id,
                    user.UserName, user.Password, user.Name, user.Email, user.Phone, user.DateOfBith, user.Gender);
                _db.Entry(user).Reload();
                await _db.SaveChangesAsync();
                //_db.Update(user);
                //await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await _db.Nhanvien.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        //POST Delete action Method
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _db.Nhanvien.FindAsync(id);
            _db.Database.ExecuteSqlCommand("EXECUTE DBO.Delete_nhanvien {0}", id);
            await _db.SaveChangesAsync();
            //_db.Users.Remove(user);
            //await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}