using BLL.Interface;
using DAL.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers.ProductCtrl
{
    public class ProductCtrl : Controller
    {
        private readonly Interface1 Repositorie;

        public ProductCtrl(Interface1 repositorie)
        {
            Repositorie = repositorie;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var product = Repositorie.GetAll();
            return View(product);
        }
        [HttpGet]
        public IActionResult Create()
        {
            // Return the view for creating a product
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                var count = Repositorie.Add(model);
                if (count > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int? id, string ViewName = "Details")
        {
            if (!id.HasValue)
                return BadRequest();

            var product = Repositorie.GetProductById(id.Value);
            if (product is null)
                return NotFound();
            return View(ViewName, product);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            return Details(id, "Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product, [FromRoute] int id)
        {
            if (id != product.id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    Repositorie.Update(product);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }

            }
            return View(product);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            return Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromRoute] int? id, Product product)
        {
            if (id != product.id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    Repositorie.Delete(product);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return View(product);
        }
    }
}