using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceDotnet
{
    interface Numb
    {
       void FindPrime(int x);
        void getOdd(int x);
    }
     class Solution : Numb 
    {
      public  void FindPrime(int x)
        {
            int count= 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    count++;
                }
            }


                if(count == 2)
                {
                    Console.WriteLine("number is prime");
                }
               
                else
                {
                    Console.WriteLine("Number is not  prime");
                }

        
        }       
    

    
       public  void getOdd(int x)
        {
             if(x%2 != 0)
            {
                Console.WriteLine("the number is odd");
            }
            else
            {
                Console.WriteLine("the number is even");
            }
        }

        
    }
}
