using System.Diagnostics;

namespace Ollamas_Unplugged_Personality.Utilities
{
    /// <summary>
    /// Provides utility methods for running 
    /// command-line commands and handling their output and errors.
    /// </summary>
    public static class CmdCommandRunner
    {
        /// <summary>
        /// Runs a command-line command with 
        /// the specified arguments and returns the output.
        /// </summary>
        /// <param name="command">The command to be executed.</param>
        /// <param name="arguments">The arguments to pass to the command.</param>
        /// <returns>The standard output of the executed command.</returns>
        public static string RunCommand(string command, string arguments)
        {
            try
            {
                // Configure the process to run the command
                var processInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",

                    // Use /C to execute and then terminate
                    Arguments = $"/C {command} {arguments}",

                    // Capture the standard output
                    RedirectStandardOutput = true,

                    // Capture the standard error
                    RedirectStandardError = true,

                    // Do not use the shell to execute
                    UseShellExecute = false,

                    // Do not create a visible window
                    CreateNoWindow = true
                };

                using var process = Process.Start(processInfo);
                if (process == null)
                    return string.Empty;

                // Read the standard output and error streams
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                // Handle any errors from the command
                HandleCommandErrors(error);
                return output;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during command execution
                ShowErrorMessage($"An error occurred: {ex.Message}");
                return string.Empty;
            }
        }

        /// <summary>
        /// Handles errors from the executed command 
        /// by showing an error message if any exist.
        /// </summary>
        /// <param name="error">
        /// The error message captured from the command.</param>
        private static void HandleCommandErrors(string error)
        {
            if (!string.IsNullOrWhiteSpace(error))
            {
                ShowErrorMessage($"Error: {error}");
            }
        }

        /// <summary>
        /// Displays an error message using a message box.
        /// </summary>
        /// <param name="message">The error message to display.</param>
        private static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
