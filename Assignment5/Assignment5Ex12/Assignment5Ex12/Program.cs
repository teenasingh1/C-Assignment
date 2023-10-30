using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace Assignment5
{
    internal class Exercise12
    {
        class Program
        {
            static void Main()
            {
                var numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
               
                // 1. Find odd - Lambda Expression – without curly brackets
                var odds = numbers.Where(x => x % 2 == 1);
                Console.WriteLine("Odd numbers: " + string.Join(", ", odds));
                
                // 2. Find Even - Lambda Expression – with curly brackets
                var evens = numbers.Where(x =>
                {
                    return x % 2 == 0;
                });
                Console.WriteLine("Even numbers: " + string.Join(", ", evens));
               
                // 3. Find Prime – Anonymous Method
                var primes = numbers.Where(delegate (int x)
                {
                    if (x < 2) return false;
                    for (int i = 2; i < x; i++)
                    {
                        if (x % i == 0) return false;
                    }
                    return true;
                });
                Console.WriteLine("Prime numbers: " + string.Join(", ", primes));
                
                // 4. Find Prime Another – Lambda Expression
                var primes2 = numbers.Where(x =>
                {
                    if (x < 2) return false;
                    for (int i = 2; i < x; i++)
                    {
                        if (x % i == 0) return false;
                    }
                    return true;
                });
                Console.WriteLine("Prime numbers: " + string.Join(", ", primes2));

                // 5. Find Elements Greater Than Five – Method Group Conversion Syntax
                List<int> greaterThanFive = numbers.Where(IsGreaterThanFive).ToList();
                Console.WriteLine("Numbers greater than five: " + string.Join(", ", greaterThanFive));

                // 6. Find Less than Five – Delegate Object in Where – Method Group Conversion Syntax in Constructor of Object
                Func<int, bool> isLessThanFive = new Func<int, bool>(IsLessThanFive);
                List<int> lessThanFive = numbers.Where(isLessThanFive).ToList();
                Console.WriteLine("Numbers less than five: " + string.Join(", ", lessThanFive));
                bool IsGreaterThanFive(int n)
                {
                    return n > 5;
                }
                bool IsLessThanFive(int n)
                {
                    return n < 5;
                }

                // 7. Find 3k – Delegate Object in Where –Lambda Expression in Constructor of Object 
                var threeK = numbers.Where(new Func<int, bool>(x => x % 3 == 0));
                Console.WriteLine("Numbers divisible by 3: " + string.Join(", ", threeK));
                
                // 8. Find 3k + 1 - Delegate Object in Where –Anonymous Method in Constructor of Object 
                var threeKPlusOne = numbers.Where(new Func<int, bool>(delegate (int x)
                {
                    return x % 3 == 1;
                }));
                Console.WriteLine("Numbers of the form 3k+1: " + string.Join(", ", threeKPlusOne));
                
                // 9. Find 3k + 2 - Delegate Object in Where –Lambda Expression Assignment 
                Func<int, bool> threeKPlusTwoDelegate = x => x % 3 == 2;
                var threeKPlusTwo = numbers.Where(threeKPlusTwoDelegate);
                Console.WriteLine("Numbers of the form 3k+2: " + string.Join(", ", threeKPlusTwo));
                
                // 10. Find anything - Delegate Object in Where – Anonymous Method Assignment
                Func<int, bool> anything = delegate (int x) { return true; };
                List<int> anythingList = numbers.Where(anything).ToList();
                Console.WriteLine("Anything: " + string.Join(", ", anythingList));
                
                // 11. Find anything - Delegate Object in Where – Method Group Conversion Assignment
                Func<int, bool> anything2 = new Func<int, bool>(Anything);
                List<int> anythingList2 = numbers.Where(anything2).ToList();
                Console.WriteLine("Anything 2: " + string.Join(", ", anythingList2));
            }
            static bool Anything(int n)
            {
                return true;
            }
        }
    }
}
