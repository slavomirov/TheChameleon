using System.Threading.Tasks;
using TheChameleon.Data;
using TheChameleon.Data.Models;
using TheChameleon.ViewModels;

namespace TheChameleon.Services
{
    public class CarsService
    {
        private readonly string[] allowedExtensions = new[] { "jpg", "png", "gif", "jpeg" };
        private readonly ApplicationDbContext dbContext;

        public CarsService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddAsync(CarsAddViewModel input)
        {
            Car car = new Car 
            {
                BuyNowPrice = input.BuyNowPrice,
                CurrentBid = 0,
                Description = input.Description,
                HorsePower = input.HorsePower,
                Make = input.Make,
                Model = input.Model,
                NextMinimumBid = input.StartingPrice, // because the current bid is 0, then when someone bids for first time, it will be the starting price
                StartingPrice = input.StartingPrice,
                Year = input.Year,
                Color = input.Color,
                Doors = input.Doors,
                Seats = input.Seats,
                Transmission = input.Transmission
            };


            await this.dbContext.AddAsync<Car>(car);
            await this.dbContext.SaveChangesAsync();
        }

    }
}
