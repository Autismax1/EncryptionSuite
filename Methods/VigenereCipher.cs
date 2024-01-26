using System;
using System.Linq;

namespace EncryptionSuite.Methods
{
    class VigenereCipher : BaseMethod
    {
        private string key;
        
        public override void Encrypt()
        {
            
        }
        
        public override void Decrypt()
        {
            
        }
        
        /// <summary>
        /// Gets the input for the vigenere cipher
        /// the input has to be a string and quite long
        /// </summary>
        public override void SetKeys()
        {
            Console.WriteLine("What is the key?");
            Console.Write("/>");
            key = Console.ReadLine();
        }
    }
}