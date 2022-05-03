using System.ComponentModel.DataAnnotations;
using TheChameleon.Data.Common.Models;

namespace TheChameleon.Data.Models
{
    public class Extra : BaseModel<int>
    {

        [Required]
        public string Name { get; set; }
    }
}
