using TheChameleon.Data.Common.Models;

namespace TheChameleon.Data.Models
{
    public class CarExtra : BaseModel<int>
    {

        public string CarId { get; set; }
        public Car Car { get; set; }

        public int ExtraId { get; set; }
        public Extra Extra { get; set; }
    }
}
