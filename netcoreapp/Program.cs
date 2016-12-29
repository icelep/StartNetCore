using System;
using  ClassLibrary;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World from ibi");
            Class1 cl=new Class1();
        
            int result = cl.AddTwoNumbers(1, 2);
            Console.WriteLine("Added two numbers: {0}", result);
        }
    }
}
