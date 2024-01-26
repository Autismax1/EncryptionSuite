using System;
using EncryptionSuite.Methods;

namespace EncryptionSuite {
    
    internal class Program
    {
        private static CeasarCipher ceasar;
        private static VigenereCipher vigenere;
        private static RSACipher rsa;
        
        static void Main()
        {

            ceasar = new CeasarCipher();
            vigenere = new VigenereCipher();
            rsa = new RSACipher();
            
            Console.WriteLine("Hello World!");
            InitialOutput();
            string userInput = GetUserInput(); 
            ValidateUserInput(userInput);
            string userEndingInput = GetUserEndingInput();
            ValidateUserEndingInput(userEndingInput);
        }

        #region consoleOutput
        /// <summary>
        /// Writes the initial menu to choose from to the console 
        /// </summary>
        private static void InitialOutput()
        {
            Console.WriteLine("-----EncryptionSuite-----");
            Console.WriteLine("Choose the encryption");
            Console.WriteLine("1. Ceasar cipher");
            Console.WriteLine("2. Vigenère cipher");
            Console.WriteLine("3. RSA encryption");
        }
        /// <summary>
        /// Asks the user for an input fo the chosen encryption
        /// </summary>
        /// <returns>string as user input</returns>
        private static string GetUserInput()
        {
            Console.Write("/>");

            string userInput = Console.ReadLine();
            Console.ReadLine();
            return userInput;
        }
        /// <summary>
        /// Asks the user for an input for ending or continuing the program
        /// </summary>
        /// <returns>string as user input</returns>
        private static string GetUserEndingInput()
        {
            Console.WriteLine("Do u wanna end the program (1) or continue (2)?");
            Console.Write("/>");
            return Console.ReadLine();
        }
        #endregion

        /// <summary>
        /// Validates the user input:
        /// 1: Ceasar cipher
        /// 2: Vigenere cipher
        /// 3: RSA encryption
        /// </summary>
        /// <param name="userInput">user input as string</param>
        private static void ValidateUserInput(string userInput)
        {
            switch (userInput)
            {
                case "1":
                {
                    ceasar.Run();
                    break;
                }
                case "2":
                {
                    vigenere.Run();
                    break;
                }
                case "3":
                {
                    rsa.Run();
                    break;
                }
                default:
                {
                    Console.WriteLine("invalid user input");
                    break;
                }
            }
        }
        /// <summary>
        /// Validates the user input:
        /// 1: Exit the program
        /// 2: Continue the program
        /// </summary>
        /// <param name="userInput"></param>
        private static void ValidateUserEndingInput(string userInput)
        {
            switch (userInput)
            {
                case "1":
                {
                    Environment.Exit(0);
                    break;
                }
                case "2":
                {
                    Main();
                    break;
                }
            }
        }

    }
}