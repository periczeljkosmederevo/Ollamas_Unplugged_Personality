using System.ComponentModel.DataAnnotations;

namespace Ollamas_Unplugged_Personality.Enums
{
    public enum PolitenessLevel
    {
        [Display(Name = "Neutral")]
        Neutral = 1,
        [Display(Name = "Polite")]
        Polite = 2,
        [Display(Name = "Direct")]
        Direct = 3,
        [Display(Name = "Formal")]
        Formal = 4,
        [Display(Name = "Casual")]
        Casual = 5,
        [Display(Name = "Blunt")]
        Blunt = 6,
        [Display(Name = "Respectful")]
        Respectful = 7,
        [Display(Name = "Sarcastic")]
        Sarcastic = 8,
        [Display(Name = "Tactful")]
        Tactful = 9,
        [Display(Name = "Rude")]
        Rude = 10
    }
}
