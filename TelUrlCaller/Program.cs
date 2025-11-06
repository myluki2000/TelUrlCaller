using System.Configuration;
using System.Text.RegularExpressions;

namespace TelUrlCaller
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0 || string.IsNullOrEmpty(Properties.Settings.Default.ActionUri))
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new SettingsForm());
            } else if(args.Length == 1)
            {
                Match match = Regex.Match(args[0], @"tel:((\+|0)[0-9]+)");
                
                if(!match.Success)
                {
                    MessageBox.Show("Invalid phone number URL: " + args[0]);
                    return;
                }    

                string phoneNumber = match.Groups[1].Value;
                Application.Run(new DialForm(phoneNumber));
            } else
            {
                throw new ArgumentException("Expected 0 or 1 argument(s), but received " + args.Length);
            }
        }
    }
}