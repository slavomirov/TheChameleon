using System.ComponentModel.DataAnnotations;

namespace TheChameleon.Enums
{
    public enum BodyType
    {
        Coupe,
        Hatchback,
        Minibus,
        Pickup,
        Sports,
        Saloon,
        [Display(Name = "Five Door Hatchback")]
        FiveDoorHatchback
    }
}
