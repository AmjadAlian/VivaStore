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
	[Authorize(Roles ="Admin,SuperAdmin")]
	[Area("Dashboard")]
    public class SliderHomeController : Controller
    {
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;

		public SliderHomeController(ApplicationDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<IActionResult> Index()
        {
			var sliderImages = await _context.SliderHome.OrderBy(s => s.Order).ToListAsync();
			var viewModel = _mapper.Map<List<SliderHomeVM>>(sliderImages);
			return View(viewModel);
		}

		public IActionResult Create() { 
		
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(SliderHomeVM model)
		{
			if (ModelState.IsValid)
			{
							
              model.ImgName = FilesSettings.UploadFile(model.Img, "imgs");
                
		      var sliderImage = _mapper.Map<SliderHome>(model);
			  _context.SliderHome.Add(sliderImage);
			  await _context.SaveChangesAsync();
			  return RedirectToAction(nameof(Index));
			}

		  return View(model);
		}
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null) return NotFound();

			var sliderImage = await _context.SliderHome.FindAsync(id);
			if (sliderImage == null) return NotFound();

			var viewModel = _mapper.Map<SliderHomeVM>(sliderImage);
			return View(viewModel);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, SliderHomeVM model)
		{
			if (id != model.Id) return NotFound();

			if (ModelState.IsValid)
			{
				if (model.Img != null)
				{
					model.ImgName = FilesSettings.UploadFile(model.Img, "imgs");
				}
				var sliderImage = _mapper.Map<SliderHome>(model);
				_context.SliderHome.Update(sliderImage);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(model);
		}

        public IActionResult Delete(int id)
        {
            var slider = _context.SliderHome.Find(id);
            if (slider == null)
            {
                return NotFound();
            }
            FilesSettings.DeleteFile(slider.ImgName, "imgs");
            _context.SliderHome.Remove(slider);
            _context.SaveChanges();
            return Ok(new { message = "Category Deleted Successfully" });
        }

    }
}
