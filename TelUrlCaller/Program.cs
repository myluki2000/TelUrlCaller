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
            ApplicationConfiguration.Initialize();
            if (args.Length == 0 || string.IsNullOrEmpty(Properties.Settings.Default.ActionUri))
            {
                Application.Run(new SettingsForm());
            } else if(args.Length == 1)
            {
                Match match = Regex.Match(args[0], @"tel:(\/\/)?((\+|0)[0-9]+)");
                
                if(!match.Success)
                {
                    MessageBox.Show("Invalid phone number URL: " + args[0]);
                    return;
                }    

                string phoneNumber = match.Groups[2].Value;
                phoneNumber = NormalizePhoneNumber(phoneNumber);
                Application.Run(new DialForm(phoneNumber));
            } else
            {
                throw new ArgumentException("Expected 0 or 1 argument(s), but received " + args.Length);
            }
        }

        private static string NormalizePhoneNumber(string phoneNumber)
        {
            if (Properties.Settings.Default.NormalizeNumbers || !string.IsNullOrEmpty(Properties.Settings.Default.CountryCode))
            {
                if (phoneNumber.StartsWith("00"))
                {
                    return "+" + phoneNumber.Substring("00".Length);
                }

                if (Regex.IsMatch(phoneNumber, @"^0[1-9][0-9]*$"))
                {
                    return "+" + Properties.Settings.Default.CountryCode + phoneNumber.Substring(1);
                }
            }

            return phoneNumber;
        }
    }
}