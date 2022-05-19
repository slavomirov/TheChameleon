namespace TheChameleon.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using TheChameleon.Data.Common.Models;
    using TheChameleon.Enums;

    public class Car : BaseModel<string>
    {
        public Car()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Images = new HashSet<Image>();
            this.Extras = new HashSet<Extra>();
            this.CreatedOn = DateTime.Now;
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

        public int? BuyNowPrice { get; set; }

        [Required]
        public int StartingPrice { get; set; }

        public int Step { get; set; } //Step in auction

        [Required]
        public int CurrentBid { get; set; } //Price

        public int NextMinimumBid { get; set; }

        [Required]
        public ICollection<Image> Images { get; set; }

        [Required]
        public ICollection<Extra> Extras { get; set; }
    }
}
