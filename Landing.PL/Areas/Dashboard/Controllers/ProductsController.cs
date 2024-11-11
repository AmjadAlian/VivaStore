using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VivaStore.DAL.Data;
using VivaStore.DAL.Models;
using VivaStore.PL.Areas.Dashboard.ViewModels;
using VivaStore.PL.Helpers;

namespace VivaStore.PL.Areas.Dashboard.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    [Area("dashboard")]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProductsController(ApplicationDbContext _context, IMapper mapper) {
            context = _context;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var products = context.Products.Include(p=>p.Category).ToList();
            var categoriesVm = mapper.Map<IEnumerable<ProductVM>>(products);
            return View(categoriesVm);
           
        }
        public IActionResult Create()
        {
            var categories = context.Categories.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();

            var model = new ProductFormVM
            {
                Categories = categories
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductFormVM model) {
            if (!ModelState.IsValid)
            {
                model.Categories = context.Categories.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList();

                return View(model);
            }
            model.ImgName = FilesSettings.UploadFile(model.Img, "imgs");
            foreach (var img in model.AdditionalImages)
            {
                var imgName = FilesSettings.UploadFile(img, "imgs");
                model.AdditionalImgNames.Add(imgName);
            }

            var product = mapper.Map<Product>(model);
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");



           
        }
        public IActionResult Edit(int id)
        {
            
            var product = context.Products.Find(id);
            if(product == null)
            {
                return NotFound();
            }
            var productVm = mapper.Map<ProductFormVM>(product);
            productVm.Categories = context.Categories.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
            return View(productVm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductFormVM model)
        {
          
            var productFromDb = context.Products.FirstOrDefault(p => p.Id == model.Id);

            if (productFromDb == null)
            {
               
                return NotFound();
            }
            if (model.Img == null)
            {
                ModelState.Remove("Img");
            }
            else
            {

                FilesSettings.DeleteFile(productFromDb.ImgName, "imgs");
            model.ImgName = FilesSettings.UploadFile(model.Img, "imgs");

            }

            if (model.AdditionalImages.Count != 0)
            {
                foreach (var img in model.AdditionalImages)
                {
                  
                    var imgName = FilesSettings.UploadFile(img, "imgs");
                    model.AdditionalImgNames.Add(imgName);
                }
            }

           

            mapper.Map(model, productFromDb);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details (int id)
        {
           var product = context.Products
          .Where(c => c.Id == id)
          .Include(c => c.Category)
          .FirstOrDefault();

            if (product == null)
            {
                return NotFound();
            }
            var ProdctDetailsViewModel = mapper.Map<ProductVM>(product);

            return View(ProdctDetailsViewModel);
        }
       
        public IActionResult Delete (int id)
        {
            var product = context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            FilesSettings.DeleteFile(product.ImgName,"imgs");
            context.Products.Remove(product);
            context.SaveChanges();
            return Ok(new { message = "Category Deleted Successfully" });
        }
    }
}
