using System.ComponentModel.DataAnnotations;

namespace TheChameleon.Enums
{
    public enum FuelType
    {
        Diesel,
        Electric,
        Gas,
        [Display(Name = "Hybrid/Electric")]
        HybridElectric,
        Petrol,
        [Display(Name = "Petrol/Gas")]
        PetrolAndGas,
    }
}
