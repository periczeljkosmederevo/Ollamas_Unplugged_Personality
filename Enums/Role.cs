using System.ComponentModel.DataAnnotations;

namespace Ollamas_Unplugged_Personality.Enums
{
    public enum Role
    {
        [Display(Name = "Participant")]
        Participant = 1,
        [Display(Name = "Moderator")]
        Moderator = 2,
        [Display(Name = "Expert")]
        Expert = 3,
        [Display(Name = "Listener")]
        Listener = 4,
        [Display(Name = "Leader")]
        Leader = 5,
        [Display(Name = "Supporter")]
        Supporter = 6,
        [Display(Name = "Critic")]
        Critic = 7,
        [Display(Name = "Disruptor")]
        Disruptor = 8,
        [Display(Name = "Observer")]
        Observer = 9,
        [Display(Name = "Skeptic")]
        Skeptic = 10,
        [Display(Name = "Encourager")]
        Encourager = 11,
        [Display(Name = "Doubter")]
        Doubter = 12,
        [Display(Name = "Mediator")]
        Mediator = 13
    }
}
