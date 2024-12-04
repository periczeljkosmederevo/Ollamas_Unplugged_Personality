using System.ComponentModel.DataAnnotations;

namespace Ollamas_Unplugged_Personality.Enums
{
    public enum Tone
    {
        [Display(Name = "Neutral")]
        Neutral = 1,
        [Display(Name = "Formal")]
        Formal = 2,
        [Display(Name = "Casual")]
        Casual = 3,
        [Display(Name = "Assertive")]
        Assertive = 4,
        [Display(Name = "Friendly")]
        Friendly = 5,
        [Display(Name = "Optimistic")]
        Optimistic = 6,
        [Display(Name = "Pessimistic")]
        Pessimistic = 7,
        [Display(Name = "Sarcastic")]
        Sarcastic = 8,
        [Display(Name = "Humorous")]
        Humorous = 9,
        [Display(Name = "Serious")]
        Serious = 10,
        [Display(Name = "Encouraging")]
        Encouraging = 11,
        [Display(Name = "Critical")]
        Critical = 12
    }
}
