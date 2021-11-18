using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Wsei.Lab1.Database;
using Wsei.Lab1.Entities;
using Wsei.Lab1.Models;

namespace Wsei.Lab1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ProductsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductModel product)
        {
            var entity = new ProductEntity
            {
                Name = product.Name,
                Description = product.Description,
                IsVisible = product.IsVisible,
            };

            await _dbContext.Products.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            var viewModel = new ProductStatsViewModel
            {
                NameLength = product.Name.Length,
                DescriptionLength = product.Description.Length,
            };

            return View(viewModel);
        }
    }
}
