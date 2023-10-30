using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7Ex17
{
    class InvalidOptionException : Exception
    {
        public override string Message
        {
            get
            {
                return " You can only select options between 1 to 5 ! ";
            }
        }
    }
    class InvalidAnswerException : Exception
    {
        public InvalidAnswerException() { }
        public InvalidAnswerException(int option, int entered) : base(ErrorMessage(option, entered))
        {
        }
        static string ErrorMessage(int option, int entered)
        {
            string message = " Invalid Answer, You entered: " + entered + "\n";
            switch (option)
            {
                case 1:
                    message += " Not an even number";
                    break;
                case 2:
                    message += " Not an odd number";
                    break;
                case 3:
                    message += " Not a prime number";
                    break;
                case 4:
                    message += " Not a negative number";
                    break;
                case 5:
                    message += " Not zero";
                    break;
            }
            return message;
        }
    }
}