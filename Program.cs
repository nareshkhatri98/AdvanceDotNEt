using System;
using System.Collections.Concurrent;

namespace AdvanceDotnet
{
    //exception is any kind of error that doesn't allow to run the code below it i.e it distrub the normal flow of
    // program . Exception handiling is a machanism that handle such error such that normal flow of program can be
    // maintained the keword used in exception handling are
    // try: use to surround the code that can generate error.
    // catch: use to handle error thrown from the catch block.
    // throw: use to explicitly throw excepltion for any place.
    // finally : finally block is always executed.
    internal class Program
    {
        static void Main(string[] args)
        {
            //example on try-catch bu handling : divde by 0 exception..
            try
            {
                Console.WriteLine("Enter first number");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int num2 = Int32.Parse(Console.ReadLine());
                int Div = num1 / num2;
                Console.WriteLine("Division is " + Div);

                // handiling indexoutof bounds exception : if 
                // attempt is made to insert data beyound the size of array.

                int[] arr1 = new int[5];// size of array is 5.

                arr1[0] = 1;
                arr1[1] = 2;
                arr1[2] = 4;
                arr1[3] = 8;
                arr1[4] = 9;
                arr1[5] = 10;// out of range..
                                
            }
            
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("denomenator can't be 0" +ex);
            }
            catch(IndexOutOfRangeException i)
            {
                Console.WriteLine("size of array is executed.." +i);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("this is finally block..");
                Console.WriteLine("it is always executed...");
            }

            Console.WriteLine("result is generated");
            Console.WriteLine("hllo bca 5th sem");

            // example own exception (user define exception..)..
            Console.WriteLine("--example on user defined exception -- ");

            ownExceptionDemo obj = new ownExceptionDemo();
            try
            {
                obj.sendYourage(14);
            }catch(AgeException a)
            {
                Console.WriteLine(a);
            }
            // Calculate the volum.
            Box b1 = new Box();
            b1.Length = 5.55;
            b1.Breadth = 5.1;
            b1.Height = 1.2;
            double Volumn = b1.Length * b1.Breadth * b1.Height;
            Console.WriteLine("The volume of box:" + Volumn);

            // calling interface
            Solution s1 = new Solution();
            s1.FindPrime(6);
            s1.getOdd(6);

            Console.ReadKey();
        }
    }
}
