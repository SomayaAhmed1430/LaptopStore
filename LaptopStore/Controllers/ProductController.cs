using LaptopStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaptopStore.Controllers
{
    public class ProductController : Controller
    {
        ProductBL productBL = new ProductBL();
        //URL "Product/All"
        public IActionResult All()
        {
            //1) model get data
            List<Product> PList = productBL.GetAll();
            //2) send to view

            return View("ShowAll", PList);
        }

        //URL "Product/ProductDetails/1"
        //URL "Product/ProductDetails?id=1"
        public IActionResult ProductDetails(int id) 
        {
            Product PModel = productBL.GetById(id);
            return View("ProductDetails", PModel);
        }
    }

}
