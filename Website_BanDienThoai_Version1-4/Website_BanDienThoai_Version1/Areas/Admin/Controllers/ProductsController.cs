using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Website_BanDienThoai_Version1.Data;
using Website_BanDienThoai_Version1.Models;
using Website_BanDienThoai_Version1.Models.ViewModel;
using Website_BanDienThoai_Version1.Utility;

namespace Website_BanDienThoai_Version1.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly HostingEnvironment _hostingEnviroment;

        [BindProperty]
        public ProductViewModel ProductsVM { get; set; }

        public ProductsController(ApplicationDbContext db, HostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnviroment = hostingEnvironment;
            ProductsVM = new ProductViewModel()
            {
                Category = _db.Category.ToList(),
                SpecialTag = _db.SpecialTag.ToList(),
                Products = new Models.Products()
            };
 
        }

        public IActionResult Index()
        {
           
            return View(_db.Products.FromSql("EXECUTE DBO.Select_All_Product"));
        }
        //Get: Products Create
        public IActionResult Create()
        {
            return View(ProductsVM);
        }
        //Post: Product Create
        [HttpPost,ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            if(!ModelState.IsValid)
            {
                return View(ProductsVM);
            }
            _db.Products.Add(ProductsVM.Products);
            await _db.SaveChangesAsync();
            //Image Save
            string wedRootPath = _hostingEnviroment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var productsFromDb = _db.Products.Find(ProductsVM.Products.Id);

            if (files.Count != 0)
            {
                //Image has beem uploaded
                var uploads = Path.Combine(wedRootPath, SD.ImageFolder);
                var extention = Path.GetExtension(files[0].FileName);
                using (var filestream = new FileStream(Path.Combine(uploads, ProductsVM.Products.Id + extention), FileMode.Create))
                {
                    files[0].CopyTo(filestream);

                }
                productsFromDb.Image = @"\" + SD.ImageFolder + @"\" + ProductsVM.Products.Id + extention;


            }
            else
            {
                var uploads = Path.Combine(wedRootPath, SD.ImageFolder + @"\" + SD.DefaultProductImage);
                System.IO.File.Copy(uploads, wedRootPath + @"\" + SD.ImageFolder + @"\" +ProductsVM.Products.Id+"png");
                productsFromDb.Image = @"\" + SD.ImageFolder + @"\" + ProductsVM.Products.Id + "png";

            }
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        //GET: Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            ProductsVM.Products = await _db.Products
                .Include(m => m.SpecialTag)
                .Include(m => m.Category)
                .SingleOrDefaultAsync(m=>m.Id==id);
            if(ProductsVM.Products==null)
            {
                return NotFound();
            }
            return View(ProductsVM);
        }
        //POST: EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            if(ModelState.IsValid)
            {
                string webRootPath = _hostingEnviroment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                var productFromDb = _db.Products.Where(m => m.Id == ProductsVM.Products.Id).FirstOrDefault();

                if(files.Count>0&&files[0]!=null)
                {
                    //if user uploads a new image
                    var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                    var extention_new = Path.GetExtension(files[0].FileName);
                    var extention_old = Path.GetExtension(productFromDb.Image);
                    if(System.IO.File.Exists(Path.Combine(uploads,ProductsVM.Products.Id+extention_old)))
                    {
                        System.IO.File.Delete(Path.Combine(uploads, ProductsVM.Products.Id + extention_old));
                    }
                    using (var filestream = new FileStream(Path.Combine(uploads, ProductsVM.Products.Id + extention_new), FileMode.Create))
                    {
                        files[0].CopyTo(filestream);

                    }
                    ProductsVM.Products.Image = @"\" + SD.ImageFolder + @"\" + ProductsVM.Products.Id + extention_new;

                }
                if(ProductsVM.Products.Image!=null)
                {
                    productFromDb.Image = ProductsVM.Products.Image;
                }
                productFromDb.Name = ProductsVM.Products.Name;
                productFromDb.Memory = ProductsVM.Products.Memory;
                productFromDb.Quantity = ProductsVM.Products.Quantity;
                productFromDb.Capacity = ProductsVM.Products.Capacity;
                productFromDb.Manufacturer = ProductsVM.Products.Manufacturer;
                productFromDb.Color = ProductsVM.Products.Color;
                productFromDb.Price = ProductsVM.Products.Price;
                productFromDb.CategoryId = ProductsVM.Products.CategoryId;
                productFromDb.SpecialTagId = ProductsVM.Products.SpecialTagId;
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ProductsVM);    
        }
        //GET: Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductsVM.Products = await _db.Products
                .Include(m => m.SpecialTag)
                .Include(m => m.Category)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (ProductsVM.Products == null)
            {
                return NotFound();
            }
            return View(ProductsVM);
        }
        //GET: Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductsVM.Products = await _db.Products
                .Include(m => m.SpecialTag)
                .Include(m => m.Category)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (ProductsVM.Products == null)
            {
                return NotFound();
            }
            return View(ProductsVM);
        }
        //POST:Delete
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            string webRootPath = _hostingEnviroment.WebRootPath;
            Products products = await _db.Products.FindAsync(id);
            if(products==null)
            {
                return NotFound();
            }
            else
            {
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extention = Path.GetExtension(products.Image);
                if(System.IO.File.Exists(Path.Combine(uploads,products.Id+extention)))
                {
                    System.IO.File.Delete(Path.Combine(uploads, products.Id + extention));
                }
                _db.Products.Remove(products);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            
        }
    }
}