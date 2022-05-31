using System;
using System.IO;
using System.Linq;
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

        public async Task AddAsync(CarsAddViewModel input, string imagePath)
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

            var userCar = new UserCar
            {
                CreatedOn = DateTime.Now,
                UserId = input.UserId,
                CarId = car.Id
            };

            
            Directory.CreateDirectory($"{imagePath}/cars/");

            foreach (var image in input.Images)
            {
                var extension = Path.GetExtension(image.FileName).TrimStart('.');

                if (!this.allowedExtensions.Any(x => extension.EndsWith(x)))
                {
                    throw new Exception($"Invalid image extension {extension}");
                }

                var dbImage = new Image
                {
                    CreatedOn = DateTime.Now,
                    AddedByUserId = input.UserId,
                    Extension = extension,
                    CarId = car.Id,
                };

                car.Images.Add(dbImage);

                var physicalPath = $"{imagePath}/cars/{dbImage.Id}.{extension}";

                // "/images/cars/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension
                dbImage.RemoteImageUrl = "/images/cars/" + dbImage.Id + "." + dbImage.Extension;
                using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                await image.CopyToAsync(fileStream);
            }

            ApplicationUser user = (ApplicationUser)this.dbContext.Users.FirstOrDefault(x => x.Id == input.UserId);
            user.CountOfPosts++;

            await this.dbContext.AddAsync<Car>(car);
            await this.dbContext.AddAsync<UserCar>(userCar);
            await this.dbContext.SaveChangesAsync();
        }

    }
}
