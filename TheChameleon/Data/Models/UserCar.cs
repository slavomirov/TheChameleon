namespace TheChameleon.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using TheChameleon.Data.Common.Models;

    public class UserCar : BaseModel<int>
    {
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string ItemId { get; set; }

        public Car Item { get; set; }
    }
}
