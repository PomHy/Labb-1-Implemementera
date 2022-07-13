using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1.Singleton
{
    public sealed class ErrorMessage
    {
        private static ErrorMessage instance = null;
        public static ErrorMessage GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new ErrorMessage();
                return instance;
            }
        }

        public void WrongInputMessage()
        {
            Console.WriteLine("Wrong input, try again.");
        }
    }

}
