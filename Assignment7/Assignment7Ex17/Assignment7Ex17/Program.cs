using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7Ex17
{
    public class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            while (true)
            {
                Console.Write("\n\n --- Math Game --- \n\n");
                Console.Write(" Enter any number from 1-5:: ");
                int option1;
                int option2;
                string question = "";
                try
                {
                    option1 = int.Parse(Console.ReadLine());
                    if (option1 > 5 || option1 < 1)
                        throw new InvalidOptionException();
                }
                catch (InvalidOptionException ex)
                {
                    Console.Write(ex.Message);
                    continue;
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    continue;
                }
                Console.WriteLine(" Option Seleted:: {0}\n", option1);
                switch (option1)
                {
                    case 1:
                        question = " Enter even number:: ";
                        break;
                    case 2:
                        question = " Enter odd number:: ";
                        break;
                    case 3:
                        question = " Enter prime number:: ";
                        break;
                    case 4:
                        question = " Enter negative number:: ";
                        break;
                    case 5:
                        question = " Enter zero number:: ";
                        break;
                }
                Console.Write(question);
                try
                {
                    option2 = int.Parse(Console.ReadLine());
                    if (Validate(option1, option2))
                        Console.WriteLine("\n Success!");
                }
                catch (InvalidAnswerException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                try
                {
                    if (index == 4) throw new Exception(" You have played this game for 5 times!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                index++;
            }
        }
        static bool Validate(int option, int entered)
        {
            switch (option)
            {
                case 1:
                    if (entered % 2 == 0) return true;
                    break;
                case 2:
                    if (entered % 2 != 0) return true;
                    break;
                case 3:
                    if (isPrime(entered)) return true;
                    break;
                case 4:
                    if (entered < 0) return true;
                    break;
                case 5:
                    if (entered == 0) return true;
                    break;
            }
            throw new InvalidAnswerException(option, entered);
        }
        public static bool isPrime(int n)
        {
            int m = n / 2;
            for (int i = 2; i <= m; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        
    }
}
