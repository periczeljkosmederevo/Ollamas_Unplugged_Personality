using System.ComponentModel.DataAnnotations;

namespace Ollamas_Unplugged_Personality.Enums
{
    public enum ConversationStyle
    {
        [Display(Name = "Quiet Soul")]
        QuietSoul = 1,
        [Display(Name = "Listener")]
        Listener = 2,
        [Display(Name = "Jokester")]
        Jokester = 3,
        [Display(Name = "Casual Conversationalist")]
        CasualConversationalist = 4,
        [Display(Name = "Deep Thinker")]
        DeepThinker = 5,
        [Display(Name = "Story Teller")]
        StoryTeller = 6,
        [Display(Name = "Debater")]
        Debater = 7,
        [Display(Name = "Inquisitive Mind")]
        InquisitiveMind = 8,
        [Display(Name = "Chatterbox")]
        Chatterbox = 9
    }
}
