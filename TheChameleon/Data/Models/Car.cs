namespace TheChameleon.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using TheChameleon.Data.Common.Models;

    public class Car : BaseModel<string>
    {
        public Car()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Images = new HashSet<Image>();
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

        public int BuyNowPrice { get; set; }

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
