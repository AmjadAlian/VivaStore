using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VivaStore.DAL.Data;
using VivaStore.PL.Areas.Dashboard.ViewModels;

namespace VivaStore.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public OrdersController(ApplicationDbContext _context, IMapper mapper)
        {
            context = _context;
            this.mapper = mapper;
        }
        public async Task <IActionResult> Index()
        {
            var orders = await context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .ToListAsync();

           
            var orderViewModels = mapper.Map<List<OrderVM>>(orders);
            return View(orderViewModels);
        }

        public IActionResult Details(int id)
        {
            var order = context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .FirstOrDefault(o => o.Id == id);

            if (order == null)
            {
                return NotFound(); 
            }

            
            var orderViewModel = mapper.Map<OrderVM>(order);
            return View(orderViewModel);
        }

        [HttpPost]
        public IActionResult UpdateStatus(int id, string status)
        {
            var order = context.Orders.Find(id);
            if (order != null)
            {
                order.Status = status;
                context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
