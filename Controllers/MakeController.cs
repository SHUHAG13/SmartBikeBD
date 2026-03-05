using Microsoft.AspNetCore.Mvc;
using SmartBikeBD.Models;


namespace SmartBikeBD.Controllers
{
    public class MakeController : Controller
    {
        public IActionResult Bikes()
        {
          Make make=new Make
          {
              Id = 1,
              Name = "Yamaha"
          };
            //return View(make);
            ContentResult CR = new ContentResult { Content = "Hello World!" };
            return CR;
        }
    }
}
