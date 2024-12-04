using System.ComponentModel.DataAnnotations;

namespace Ollamas_Unplugged_Personality.Enums
{
    public enum DetailLevel
    {
        [Display(Name = "Minimal")]
        Minimal = 1,
        [Display(Name = "Moderate")]
        Moderate = 2,
        [Display(Name = "Comprehensive")]
        Comprehensive = 3
    }
}
