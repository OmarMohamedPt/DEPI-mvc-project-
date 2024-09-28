using BLL.Interface;
using BLL.Repositories;
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

        public IActionResult Index()
        {
            var product = Repositorie.GetAll();
            return View(product);
        }
    }
}
