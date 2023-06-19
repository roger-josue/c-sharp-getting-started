using System;
namespace c_sharp_getting_started
{
	static class Cipher
	{
        private static char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

		public static void Encrypt()
		{
            Console.Write("Please, type in your message to cipher: ");
            string message = Console.ReadLine();
            if(message == null)
            {
                Console.WriteLine("You did not type a message.\nEND...");
            } else
            {
                char[] secretMessage = message.ToCharArray();
                char[] encryptedMessage = new char[secretMessage.Length];
                for (int i = 0; i < secretMessage.Length; i++)
                {
                    char character = secretMessage[i];
                    int idx = Array.IndexOf(alphabet, character);
                    int newIdx = (idx + 3) % alphabet.Length;
                    char newCharacter = alphabet[newIdx];
                    encryptedMessage[i] = newCharacter;
                }

                 Console.WriteLine($"\nYour encrypted message: {String.Join("", encryptedMessage)}");
                Console.WriteLine("\n\nEND...");
            }
		}
	}
}

