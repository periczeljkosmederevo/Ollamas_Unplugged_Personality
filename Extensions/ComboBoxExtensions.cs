namespace Ollamas_Unplugged_Personality.Extensions
{
    /// <summary>
    /// Provides extension methods for working with ComboBox controls.
    /// </summary>
    public static class ComboBoxExtensions
    {
        /// <summary>
        /// Populates the ComboBox with the display names of values from an enum type.
        /// </summary>
        /// <typeparam name="T">The enum type to use for populating the ComboBox.</typeparam>
        /// <param name="comboBox">The ComboBox to populate.</param>
        public static void PopulateWithEnumValues<T>(this ComboBox comboBox) where T : Enum
        {
            // Retrieve display names for the enum values
            var enumValues = EnumExtensions.GetEnumDisplayNames<T>();

            // Set the ComboBox data source to the retrieved display names
            comboBox.DataSource = enumValues;
        }
    }
}

