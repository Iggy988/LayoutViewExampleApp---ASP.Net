using Microsoft.AspNetCore.Mvc;

namespace LayoutViewExample.Controllers;

public class ProductsController : Controller
{
    [Route("products")]
    public IActionResult Index()
    {
        return View();
    }

    //Url: /search-product/1
    [Route("search-products/{ProductID?}")]
    public IActionResult Search(int? ProductId)
    {
        ViewBag.ProductIDD = ProductId;
        return View();
    }

    [Route("order-products")]
    public IActionResult Order()
    {
        return View();
    }
}
