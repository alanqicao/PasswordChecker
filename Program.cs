using System.Text;

namespace PasswordChecker
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("==== Password App Menu ====");
                Console.WriteLine("1. Check Password Strength");
                Console.WriteLine("2. Generate Password");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CheckPassword();
                        break;
                    case "2":
                        GeneratePasswordOption();
                        break;
                    case "3":
                        Console.WriteLine("Exiting the application. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }

         
        }

        /// <summary>
        /// Prompts the user to enter a password and displays its strength.
        /// </summary>
        static void CheckPassword()
        {
            Console.Write("Enter the password to check:");
            string password = Console.ReadLine();
            string strength = GetPasswordStrength(password);
            Console.WriteLine($"Password Strength:{strength}");
        }

        /// <summary>
        /// Determines the strength of a password based on its length and character variety.
        /// </summary>
        /// <param name="password">The password string to evaluate.</param>
        /// <returns>A string indicating the password strength.</returns>
        static string GetPasswordStrength(string password) 
        {
            if (password.Length < 8)
            { 
                return "Too Short";
            }
           
            int score = 0;

            if (password.Any(char.IsLower)) 
            {
                score++;
            }

            if (password.Any(char.IsUpper))
            {
                score++;
            }

            if (password.Any(char.IsDigit))
            {
                score++;
            }

            if (password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                score++;
            }

            if (score <= 1)
            {
                return "Weak";
            }
            else if (score == 2)
            {
                return "Moderate";
            }
            else if (score >= 3)
            {
                return "Strong";
            }
            else
            {
                return "Unknown";
            }
        }

        /// <summary>
        /// Prompts the user for a desired password length and generates a password.
        /// </summary>
        static void GeneratePasswordOption()
        {
            Console.WriteLine("Enter desired passwrod length (8-16): ");
            if (!int.TryParse(Console.ReadLine(), out int length))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            if (length < 8 || length > 16)
            {
                Console.WriteLine("Password length must be between 8 and 16 characters.");
            }

            string password = GeneratePassword(length);
            Console.WriteLine($"Generated Password: {password}");
        }

        /// <summary>
        /// Generates a random password ensuring at least one lowercase, uppercase, digit, and special character.
        /// </summary>
        /// <param name="length">The total length of the password to generate.</param>
        /// <returns>A randomly generated password string.</returns>
        static string GeneratePassword(int length)
        {
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            const string special = "!@#$%^&*()";

            StringBuilder passwordBuilder = new StringBuilder();
            passwordBuilder.Append(lower[random.Next(lower.Length)]);
            passwordBuilder.Append(upper[random.Next(upper.Length)]);
            passwordBuilder.Append(digits[random.Next(digits.Length)]);
            passwordBuilder.Append(special[random.Next(special.Length)]);

            string allChars = lower +upper + digits + special;

            for (int i = 4; i < length; i++)
            {
                passwordBuilder.Append(allChars[random.Next(allChars.Length)]);
            }
            return ShuffleString(passwordBuilder.ToString());
        }

        /// <summary>
        /// Shuffles the characters in a string randomly.
        /// </summary>
        /// <param name="input">The string to shuffle.</param>
        /// <returns>A new string with shuffled characters.</returns>
        static string ShuffleString(string input)
        {
            char[] array = input.ToCharArray();
            int n = array.Length;
            for (int i = 0; i < n; i++) 
            {
                int j = random.Next(i, n);

                char temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            return new string(array);
        }
    }
}
