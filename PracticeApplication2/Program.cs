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

        //Static method
        public static void Method4()
        {
            Console.WriteLine("From Method 4");
        }

        //Extension Method
        public string Method5(this string a, string b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }
    }

    public class VarVsDynamic
    {
        public VarVsDynamic()
        {
            var a = 1;
            a = "one"; //Cannot be reinitialized to different type.

            dynamic b = 1;
            b = "one"; // Can be reinitialized to different type.
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
