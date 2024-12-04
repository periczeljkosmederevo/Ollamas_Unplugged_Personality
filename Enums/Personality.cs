using System.ComponentModel.DataAnnotations;

namespace Ollamas_Unplugged_Personality.Enums
{
    public enum Personality
    {
        [Display(Name = "Neutral")]
        Neutral = 1,
        [Display(Name = "Confident")]
        Confident = 2,
        [Display(Name = "Empathetic")]
        Empathetic = 3,
        [Display(Name = "Humorous")]
        Humorous = 4,
        [Display(Name = "Serious")]
        Serious = 5,
        [Display(Name = "Curious")]
        Curious = 6,
        [Display(Name = "Optimistic")]
        Optimistic = 7,
        [Display(Name = "Pessimistic")]
        Pessimistic = 8,
        [Display(Name = "Calm")]
        Calm = 9,
        [Display(Name = "Energetic")]
        Energetic = 10,
        [Display(Name = "Analytical")]
        Analytical = 11,
        [Display(Name = "Creative")]
        Creative = 12,
        [Display(Name = "Cynical")]
        Cynical = 13,
        [Display(Name = "Apathetic")]
        Apathetic = 14,
        [Display(Name = "Aggressive")]
        Aggressive = 15,
        [Display(Name = "Insecure")]
        Insecure = 16,
        [Display(Name = "Impulsive")]
        Impulsive = 17
    }
}
