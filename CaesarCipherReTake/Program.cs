﻿using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Enter message here: ");
            string message = Console.ReadLine();
            char[] secretMessage = message.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char accessChar = secretMessage[i];
                int index = Array.IndexOf(alphabet, accessChar);
                int indexThree = ((index + 3) % 26);
                char letter = alphabet[indexThree];
                encryptedMessage[i] = letter;
            }
            var newMessage = String.Join("", encryptedMessage);
            Console.WriteLine(newMessage);

//ask Dave how to rewrite method to skip symbols in console print if message is weritten with any
                

        }
    }
}