using System;

namespace EncryptionSuite.Methods
{
    abstract class BaseMethod
    {

        public string _userInput;
        public string _resultOutput;
        public bool _encrypt;

        public void Run()
        {
            SetDirection();
            SetUserInput();
            SetKeys();
            Execute();
            OutputResult();
        }
        
        private void Execute()
        {
            if (_encrypt)
            {
                Encrypt();
            }
            else
            {
                Decrypt();
            }
        }
        
        public virtual void SetKeys()
        {
            
        }

        public virtual void Encrypt()
        {
            
        }

        public virtual void Decrypt()
        {
            
        }
        
        private void SetDirection()
        {
            Console.WriteLine("Encrypt (1) ord Decrypt (2)?");
            Console.Write("/>");
            string result = Console.ReadLine();
            switch (result)
            {
                case "1":
                {
                    _encrypt = true;
                    break;
                }
                case "2":
                {
                    _encrypt = false;
                    break;
                }
                default:{
                    Console.WriteLine("Invalid user input");
                    SetDirection();
                    break;
                }
            }
        }
        
        private void SetUserInput()
        {
            if(_encrypt)
            {
                Console.WriteLine("What do u wanna encrypt?");
                Console.Write("/>");
                _userInput = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What do u wanna decrypt?");
                Console.Write("/>");
                _userInput = Console.ReadLine();
            }
        }
        
        private void OutputResult()
        {
            if (_encrypt)
            {
                Console.WriteLine("Encrypted Result:" + _resultOutput);
            }
            else
            {
                Console.WriteLine("Decrypted Result:" + _resultOutput);
            }
        }
        
    }
}