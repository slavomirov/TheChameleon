namespace TheChameleon.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using TheChameleon.Data.Common.Models;

    public class UserCar : BaseModel<int>
    {
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string CarId { get; set; }

        public Car Car { get; set; }
    }
}
