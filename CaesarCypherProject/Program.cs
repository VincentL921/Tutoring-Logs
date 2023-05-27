using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Insert secret message here: ");
            string message = Console.ReadLine();
            char[] secretMessage = message.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char characterAccess = secretMessage[i];
                int index = Array.IndexOf(alphabet, characterAccess);
                int indexThree = (index + 3);
                int adjustedIndex = indexThree > alphabet.Length ? indexThree - alphabet.Length : indexThree;
                char encryptChar = alphabet[adjustedIndex];
                encryptedMessage[i] = encryptChar;

                Console.WriteLine(characterAccess);
                Console.WriteLine(index);
                Console.WriteLine(indexThree);
                Console.WriteLine(encryptChar);
                Console.WriteLine("");
                Console.WriteLine("");
                //char encryptChar = alphabet[indexThree];
                //encryptedMessage[i] = encryptChar;
            }
            //var newMessage = String.Join("", encryptedMessage);
            //Console.WriteLine(newMessage);
        }
    }
}