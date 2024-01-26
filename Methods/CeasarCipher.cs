using System;
using System.Linq;

namespace EncryptionSuite.Methods
{
    class CeasarCipher : BaseMethod
    {

        private int key;
        
        public override void Encrypt()
        {
            foreach (char ch in _userInput)
            {
                char d = char.IsUpper(ch) ? 'A' : 'a';
                _resultOutput += (char)((((ch + key) - d) % 26) + d);
            }
        }
        
        public override void Decrypt()
        {
            foreach (char ch in _userInput)
            {
                char d = char.IsUpper(ch) ? 'A' : 'a';
                _resultOutput += (char)((((ch - key) - d) % 26) + d);
            }
        }
        
        public override void SetKeys()
        {
            Console.WriteLine("What is the key?");
            Console.Write("/>");
            key = Convert.ToInt32(Console.ReadLine());
        }
    }
}