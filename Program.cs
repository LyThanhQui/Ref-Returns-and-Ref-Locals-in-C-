using System;

namespace Ref_Returns_and_Ref_Locals
{
    class Program
    {
        static void Main(string[] args)
        {
            int no = 2;
            PassByValue(no);
            Console.WriteLine($"After the invocation of {nameof(PassByValue)} method, {nameof(no)} = {no}");
            Console.WriteLine("Press any key to Exit.");
            Console.ReadLine();
        }
        static void PassByValue(int x)
        {
            int x1 = x;

        }
    }

}