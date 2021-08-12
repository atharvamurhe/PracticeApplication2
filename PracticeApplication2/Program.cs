using System;

namespace PracticeApplication2
{
    //Example of Different Ways to write a method
    public class MethodExamples
    {
        //Method with no return type.
        public void Method1()
        {
            Console.WriteLine("From Method 1");
        }

        //Method with some return type
        public int Method2()
        {
            Console.WriteLine("From Method 2");
            return 10;
        }

        //Method with parameters
        public void Method3(int a)
        {
            Console.WriteLine("From Method 3");
        }

        //Extension Method
        public string Method4(this string a, string b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
