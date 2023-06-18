using System;

namespace c_sharp_getting_started
{
	public class PasswordChecker
	{
		public PasswordChecker()
		{
            int minLength = 8;
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = lowercase.ToUpper();
            string digits = "0123456789";
            string specialChars = @"!@#$%^&*()-+=/?><.,{}';:`~";

            string password = Console.ReadLine();
            int score = 0;
            if (password.Length >= minLength)
            {
                score += 1;
            }
            if (Contains(password, uppercase) == true)
            {
                score += 1;
            }
            if (Contains(password, lowercase) == true)
            {
                score += 1;
            }
            if (Contains(password, digits) == true)
            {
                score += 1;
            }
            if (Contains(password, specialChars) == true)
            {
                score += 1;
            }
            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Password strenght: extremely strong");
                    break;
                case 3:
                    Console.WriteLine("Password strenght: strong");
                    break;
                case 2:
                    Console.WriteLine("Password strenght: medium");
                    break;
                case 1:
                    Console.WriteLine("Password strenght: weak");
                    break;
                default:
                    Console.WriteLine("Password strenght: Not a valid password, does not meet the criteria");
                    break;

            }
        }

        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }
    }
}

