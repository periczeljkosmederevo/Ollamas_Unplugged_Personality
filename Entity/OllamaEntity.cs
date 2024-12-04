﻿using Ollamas_Unplugged_Personality.Api;
using Ollamas_Unplugged_Personality.Enums;
using Ollamas_Unplugged_Personality.Extensions;
using Ollamas_Unplugged_Personality.Model;

namespace Ollamas_Unplugged_Personality.Entity
{
    /// <summary>
    /// Represents an abstract base class 
    /// for entities interacting with the Ollamas API.
    /// Provides context-aware response generation 
    /// and state evolution based on conversation history.
    /// </summary>
    public abstract class OllamaEntity : IOllamaEntity
    {
        #region Fields and Constants

        protected readonly IApiCommunicationHandler _apiHandler;
        private const int ContextWindowSize = 5;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance 
        /// of the <see cref="OllamaEntity"/> 
        /// class with the specified API communication handler.
        /// </summary>
        /// <param name="apiHandler">The API communication handler.</param>
        protected OllamaEntity(IApiCommunicationHandler apiHandler)
        {
            _apiHandler = apiHandler;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the name of the entity.
        /// </summary>
        public string Name { get; set; } = "Ollama";

        /// <summary>
        /// Gets or sets the model used for generating responses.
        /// </summary>
        public string Model { get; set; } = "llama3.2";

        /// <summary>
        /// Gets the last response generated by the entity.
        /// </summary>
        public string LastResponse { get; private set; } = string.Empty;

        /// <summary>
        /// Gets or sets a custom prompt used for generating responses.
        /// </summary>
        public string CustomPrompt { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether fact-checking is enabled.
        /// </summary>
        public bool FactCheckingEnabled { get; set; } = false;

        /// <summary>
        /// Gets the conversation history as a list of conversation entries.
        /// </summary>
        public List<ConversationEntry> ConversationHistory { get; private set; } = [];

        // Personality and conversation-related properties
        public Personality Personality { get; set; } = Personality.Neutral;
        public Gender Gender { get; set; } = Gender.Male;
        public Language Language { get; set; } = Language.English;
        public Role Role { get; set; } = Role.Expert;
        public FieldOfExpertise FieldOfExpertise { get; set; } = FieldOfExpertise.General;
        public ResponseLength ResponseLength { get; set; } = ResponseLength.Normal;
        public Tone Tone { get; set; } = Tone.Neutral;
        public CreativityLevel CreativityLevel { get; set; } = CreativityLevel.Balanced;
        public DetailLevel DetailLevel { get; set; } = DetailLevel.Moderate;
        public PolitenessLevel PolitenessLevel { get; set; } = PolitenessLevel.Neutral;
        public ConversationStyle ConversationStyle { get; set; } = ConversationStyle.Listener;

        #endregion

        #region Public Methods

        /// <summary>
        /// Generates a response based on the provided input.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="cancellation">The cancellation token.</param>
        /// <returns>A task representing the asynchronous operation, 
        /// with the generated response as the result.</returns>
        public virtual async Task<string> GenerateResponse(string input,
                                                           CancellationToken cancellation = default)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            // Build prompt with context
            string prompt = BuildPrompt(input);
            string response = await _apiHandler.SendRequestAsync(prompt, Model);
            LastResponse = response;

            // Store interaction in history
            ConversationHistory.Add(new ConversationEntry
            {
                Input = input,
                Response = response,
                Timestamp = DateTime.UtcNow
            });

            // Trigger state evolution based on context
            EvolveBasedOnContext();
            SummarizeContextIfNecessary();

            return response;
        }

        /// <summary>
        /// Generates a personal profile summary of the entity.
        /// </summary>
        /// <returns>A string representing the personal profile.</returns>
        public string GeneratePersonalProfile()
        {
            return $"You are {Name}, " +
                   $"and you identify as a {Gender.GetDisplayName()}. \n" +
                   $"Your role is a {Role.GetDisplayName()} " +
                   $"with a {Personality.GetDisplayName()} personality. \n" +
                   $"Your conversation style is: {ConversationStyle.GetDisplayName()}. \n" +
                   $"Your primary focus is on the topic: {FieldOfExpertise.GetDisplayName()}. \n" +
                   $"You communicate in {Language.GetDisplayName()} " +
                   $"and maintain a {Tone.GetDisplayName()} tone. \n" +
                   $"Your response length preference is {ResponseLength.GetDisplayName()}, " +
                   $"detail level: {DetailLevel.GetDisplayName()}, \n" +
                   $"creativity level: {CreativityLevel.GetDisplayName()}, " +
                   $"and politeness level: {PolitenessLevel.GetDisplayName()}. \n" +
                   $"Fact-checking is {(FactCheckingEnabled ? "enabled" : "disabled")}.";
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Builds a prompt for generating a response based on the provided input.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>The generated prompt string.</returns>
        protected virtual string BuildPrompt(string input)
        {
            // Incorporate recent context
            var recentHistorySnippet = string.Join("\n", GetRecentContext()
                .Select(e => $"[INPUT: {e.Input}]\n[RESPONSE: {e.Response}]"));

            CustomPrompt = "Give response without introducing yourself";

            var prompt =
                $"{recentHistorySnippet}\n" +
                $"Your name is {Name}. " +
                $"You are a {Role} with a {Personality} personality. " +
                $"Tone: {Tone}, focused on {FieldOfExpertise}. " +
                $"Provide a response with {ResponseLength} length, " +
                $"{DetailLevel} detail, " +
                $"and in a {PolitenessLevel} tone. " +
                $"Use {Language}. " +
                $"Creativity level: {CreativityLevel}. " +
                $"You identify as {Gender}. " +
                $"{CustomPrompt}. " +
                $"[INPUT: {input}]";

            if (FactCheckingEnabled)
            {
                prompt += " Ensure factual accuracy.";
            }

            return prompt;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Retrieves the recent conversation context for building prompts.
        /// </summary>
        /// <returns>An enumerable of recent conversation entries.</returns>
        private IEnumerable<ConversationEntry> GetRecentContext()
        {
            return ConversationHistory.TakeLast(ContextWindowSize);
        }

        /// <summary>
        /// Evolves the state of the entity based on the conversation context.
        /// Adjusts tone, response length, 
        /// and creativity level based on keyword sentiment and sentence count.
        /// </summary>
        private void EvolveBasedOnContext()
        {
            // Adjust tone based on sentiment in conversation history
            AdjustToneBasedOnSentiment();

            // Only adjust response length if not explicitly set to Long via the UI
            if (ResponseLength == ResponseLength.Normal)
            {
                // Adjust response length based on the number of sentences in responses
                AdjustResponseLengthBasedOnSentenceCount();
            }

            // Increase creativity level if the conversation history is very long
            if (ConversationHistory.Count > 20)
            {
                CreativityLevel = CreativityLevel.High;
            }
        }

        /// <summary>
        /// Analyzes the conversation history 
        /// for sentiment keywords and adjusts the tone accordingly.
        /// </summary>
        private void AdjustToneBasedOnSentiment()
        {
            var positivityKeywords = 
                new[] { "great", "amazing", "enjoy", "happy", "exciting" };

            var negativityKeywords = 
                new[] { "boring", "dull", "stale", "disappointing", "bad" };

            var neutralKeywords = 
                new[] { "okay", "fine", "average", "so-so" };

            int positivityScore = ConversationHistory.Count(entry =>
                positivityKeywords.Any(keyword =>
                    entry.Response.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                )
            );

            int negativityScore = ConversationHistory.Count(entry =>
                negativityKeywords.Any(keyword =>
                    entry.Response.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                )
            );

            int neutralScore = ConversationHistory.Count(entry =>
                neutralKeywords.Any(keyword =>
                    entry.Response.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                )
            );

            if (positivityScore > negativityScore && positivityScore > neutralScore)
            {
                Tone = Tone.Optimistic;
            }
            else if (negativityScore > positivityScore && negativityScore > neutralScore)
            {
                Tone = Tone.Pessimistic;
            }
            else if (neutralScore > positivityScore && neutralScore > negativityScore)
            {
                Tone = Tone.Neutral;
            }
        }

        /// <summary>
        /// Adjusts the response length 
        /// if there are too many responses with an excessive number of sentences.
        /// </summary>
        private void AdjustResponseLengthBasedOnSentenceCount()
        {
            // Max number of sentences per response
            int sentenceCountThreshold = 10;

            // Threshold for the number of responses that exceed sentence limit
            int longResponseCountThreshold = 3; 

            int longResponseCount = ConversationHistory.Count(entry =>
            {
                char[] sentenceDelimiters = ['.', '!', '?'];
                int sentenceCount = entry.Response
                    .Split(sentenceDelimiters, StringSplitOptions.RemoveEmptyEntries)
                    .Length;

                return sentenceCount > sentenceCountThreshold;
            });

            if (longResponseCount >= longResponseCountThreshold)
            {
                ResponseLength = ResponseLength.Short;
            }
        }

        /// <summary>
        /// Summarizes the context of the conversation if necessary.
        /// </summary>
        private void SummarizeContextIfNecessary()
        {
            if (ConversationHistory.Count > 50)
            {
                var recentResponses = GetRecentContext()
                    .Select(e => e.Response);

                var summaryContent = string.Join(", ", recentResponses);
                var summary = $"Summary of recent conversations: {summaryContent}";

                ConversationHistory.Clear();
                ConversationHistory.Add(new ConversationEntry
                {
                    Input = "SUMMARY",
                    Response = summary,
                    Timestamp = DateTime.UtcNow
                });
            }
        }

        #endregion
    }
}