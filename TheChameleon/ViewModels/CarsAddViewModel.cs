using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TheChameleon.Data.Models;
using TheChameleon.Enums;

namespace TheChameleon.ViewModels
{
    public class CarsAddViewModel
    {
        public CarsAddViewModel()
        {
            this.Images = new HashSet<IFormFile>();
            this.Extras = new HashSet<Extra>();
        }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int HorsePower { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public int Doors { get; set; }

        [Required]
        public int Seats { get; set; }

        [Required]
        public Transmission Transmission { get; set; }

        [Required]
        public BodyType BodyType { get; set; }

        [Required]
        public FuelType FuelType { get; set; }

        public int BuyNowPrice { get; set; }

        [Required]
        public int StartingPrice { get; set; }

        public int Step { get; set; } //Step in auction

        [Required]
        public int CurrentBid { get; set; } //Price

        public int NextMinimumBid { get; set; }

        //[Required]
        public ICollection<IFormFile> Images { get; set; }

        //[Required]
        public ICollection<Extra> Extras { get; set; }

        public string UserId { get; set; }


    }
}
