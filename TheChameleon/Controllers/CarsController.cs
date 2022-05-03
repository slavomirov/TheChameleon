using Microsoft.AspNetCore.Mvc;

namespace TheChameleon.Controllers
{
    public class CarsController : Controller
    {

        public IActionResult Add()
        {
            return this.View(); 
        }
    }
}
