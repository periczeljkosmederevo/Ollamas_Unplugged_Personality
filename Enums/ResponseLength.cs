using System.ComponentModel.DataAnnotations;

namespace Ollamas_Unplugged_Personality.Enums
{
    public enum ResponseLength
    {
        [Display(Name = "Short")]
        Short = 1,
        [Display(Name = "Normal")]
        Normal = 2,
        [Display(Name = "Long")]
        Long = 3
    }
}
