using System;

namespace AdvanceDotnet
{
    // we can create our own exception type(user define)
    //exception by inheriting  Exception class
    // Step1: Create Error class by inheriting eception class
    //step2:write a program and throw own error. 
    //Step3: handle with try catch..

    // creating error class..
    class AgeException : Exception
    {
        // if age is less than 16 throw your error..
        public AgeException(string s):base(s)
        {
            Console.WriteLine("age cannot be less the 16..");
        }
    }
    class ownExceptionDemo
    {
        public void sendYourage( int age)
        {
           if(age < 16)
            {
                //throw own exception
                throw new AgeException("age  can't be less tha 16");
            }
            else
            {
                Console.WriteLine("your are eligible  to participate");
            }
        }

    }
}
