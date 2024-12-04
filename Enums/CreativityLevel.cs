using System.ComponentModel.DataAnnotations;

namespace Ollamas_Unplugged_Personality.Enums
{
    public enum CreativityLevel
    {
        [Display(Name = "Low")]
        Low = 1,
        [Display(Name = "Balanced")]
        Balanced = 2,
        [Display(Name = "High")]
        High = 3
    }
}
