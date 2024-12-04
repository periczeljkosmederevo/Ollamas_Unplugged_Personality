using System.ComponentModel.DataAnnotations;

namespace Ollamas_Unplugged_Personality.Extensions
{
    /// <summary>
    /// Provides extension methods for working with enum types, 
    /// including display name retrieval,
    /// random value selection, and string-to-enum conversions.
    /// </summary>
    public static class EnumExtensions
    {
        private static readonly Random _randomizer = new();

        /// <summary>
        /// Gets a random value from an enum type.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <returns>A randomly selected value of the specified enum type.</returns>
        public static T GetRandomValue<T>() where T : Enum
        {
            var values = Enum.GetValues(typeof(T));
            return (T)values.GetValue(_randomizer.Next(values.Length))!;
        }

        /// <summary>
        /// Converts an enum value to its underlying integer value.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="enumValue">The enum value to convert.</param>
        /// <returns>The integer representation of the enum value.</returns>
        public static int GetValue<T>(this T enumValue) where T : Enum
        {
            return Convert.ToInt32(enumValue);
        }

        /// <summary>
        /// Retrieves a list of display names for all values of an enum type.
        /// If a value does not have a display name attribute, the enum name is used.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <returns>A list of display names for the specified enum type.</returns>
        public static List<string> GetEnumDisplayNames<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<T>()
                .Select(value => value.GetDisplayName() ?? value.ToString())
                .ToList();
        }

        /// <summary>
        /// Retrieves the display name of an enum value if defined by the Display attribute;
        /// otherwise, returns the string representation of the enum value.
        /// </summary>
        /// <param name="enumValue">The enum value.</param>
        /// <returns>The display name or the string representation of the enum value.</returns>
        public static string GetDisplayName(this Enum enumValue)
        {
            var enumType = enumValue.GetType();
            var memberInfo = enumType.GetMember(enumValue.ToString());
            if (memberInfo.Length > 0)
            {
                var displayAttribute = memberInfo[0]
                    .GetCustomAttributes(typeof(DisplayAttribute), false)
                    .OfType<DisplayAttribute>()
                    .FirstOrDefault();

                if (displayAttribute != null && !string.IsNullOrEmpty(displayAttribute.Name))
                {
                    return displayAttribute.Name;
                }
            }
            return enumValue.ToString();
        }

        /// <summary>
        /// Attempts to match a string to an enum value 
        /// using its display name or string representation.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="selectedText">The string to match.</param>
        /// <param name="result">The resulting enum value if found.</param>
        /// <returns>True if a match was found; otherwise, false.</returns>
        public static bool TryGetSelectedEnumValue<T>(
            this string selectedText, out T result) where T : Enum
        {
            result = Enum.GetValues(typeof(T)).Cast<T>()
                .FirstOrDefault(value => value.GetDisplayName() == selectedText
                                    || value.ToString() == selectedText)!;

            return !EqualityComparer<T>.Default.Equals(result, default);
        }

        /// <summary>
        /// Retrieves the enum value corresponding to a string if it matches the enum name.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="selectedText">The string to match.</param>
        /// <returns>The corresponding enum value, or null if no match is found.</returns>
        public static T? GetSelectedEnumValue<T>(this string selectedText) where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<T>()
                .FirstOrDefault(value => value.ToString() == selectedText);
        }
    }
}
