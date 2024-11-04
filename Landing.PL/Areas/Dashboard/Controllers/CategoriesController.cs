using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VivaStore.DAL.Data;
using VivaStore.DAL.Models;
using VivaStore.PL.Areas.Dashboard.ViewModels;
using VivaStore.PL.Helpers;

namespace VivaStore.PL.Areas.Dashboard.Controllers
{
    [Authorize(Roles ="Admin,superAdmin")]
    [Area("dashboard")]
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CategoriesController(ApplicationDbContext _context,IMapper mapper)
        {
            context = _context;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
           var cateogries = context.Categories.ToList();
            var categoriesVm = mapper.Map<IEnumerable <CategoryVM>>(cateogries);
            return View(categoriesVm);
        }
     
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryFormVM model)
        {
            if (!ModelState.IsValid) { 
            return View(model);
            }
            model.ImgName = FilesSettings.UploadFile(model.Img, "imgs");
            var category = mapper.Map<Category>(model);
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var category = context.Categories
           .Where(c => c.Id == id)
           .Include(c => c.Products) 
           .FirstOrDefault();

            if (category == null)
            {
                return NotFound();
            }

            var categoryDetailsViewModel = mapper.Map<CategoryDetailsVM>(category);

            return View(categoryDetailsViewModel);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = context.Categories.Find(id);
            var categoryVm = mapper.Map<CategoryVM>(category);
            return View(categoryVm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryVM model) 
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var categoryFormDb = context.Categories.Find(model.Id);
            if (categoryFormDb == null)
            {
                return NotFound();
            }
            model.ImgName = FilesSettings.UploadFile(model.Img, "imgs");
            mapper.Map(model, categoryFormDb);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        [HttpPost]
        
        public IActionResult Delete (int id)
        {
            var category = context.Categories.Find(id);
            if(category == null)
            {
                return RedirectToAction(nameof(Index)); 
            }
            FilesSettings.DeleteFile(category.ImgName,"imgs");
            context.Categories.Remove(category);
            context.SaveChanges();
            return Ok(new {message="Category Deleted Successfully"});
        }
      
    }
}
