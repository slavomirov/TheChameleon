using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using TheChameleon.Services;
using TheChameleon.ViewModels;

namespace TheChameleon.Controllers
{
    public class CarsController : Controller
    {
        private readonly CarsService carsService;
        private readonly IWebHostEnvironment environment;


        public CarsController(CarsService carsService, IWebHostEnvironment environment)
        {
            this.carsService = carsService;
            this.environment = environment;
        }

        //[Authorize]
        public IActionResult Add()
        {
            //var viewModel = new CarsAddViewModel();
            return this.View(/*viewModel*/);
        }
        
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(CarsAddViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/Shared/Error");
            }

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {
                input.UserId = userId;
            }

            try
            {
                await this.carsService.AddAsync(input, $"{this.environment.WebRootPath}/images");
            }
            catch (System.Exception)
            {
                return this.Redirect("/Shared/Error");
            }

            this.TempData["Message"] = "Car added successfully.";
            return this.Redirect("/");
        }


    }
}
