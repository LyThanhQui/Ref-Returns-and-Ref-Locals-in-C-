using System;

namespace Ref_Returns_and_Ref_Locals
{
    class Program
    {
        //Passing by Value in C#
        /* static void Main(string[] args)
         {
             int no = 1;
             PassByValue(no);
             Console.WriteLine($"After the invocation of {nameof(PassByValue)} method, {nameof(no)} = {no}");
             Console.WriteLine("Press any key to Exit.");
             Console.ReadLine();
         }
         static void PassByValue(int x)
         {
             x = 2;

         }*/

        //Passing by Reference in C#
        /*  static void Main(string[] args)
          {
              int no = 1;
              PassByReference(ref no);
              Console.WriteLine($"After the invocation of {nameof(PassByReference)} method, {nameof(no)} = {no}");
              Console.WriteLine("Press any key to Exit.");
              Console.ReadLine();
          }
          static void PassByReference(ref int x)
          {
              x = 2;
          }
          */
        //Out Variable in C#:
        /* static void Main(string[] args)
         {
             // int no;// does not need to be initialized value for no variable
             //OUT(out no);
             //in C# 7.0
             OUT(out int no);
             Console.WriteLine($"After the invocation of {nameof(OUT)} method, {nameof(no)} = {no}");
             Console.WriteLine("Press any key to Exit.");
             Console.ReadLine();
         }
         static void OUT(out int x)
         {
             x = 4 * 2;

         }
         */
        //Ref Local in C#
        /*  static void Main(string[] args)
          {
              int no1 = 1;
              ref int no2 = ref no1;
              no2 = 1321312;
              ref int no3 = ref no2;
              no3 = 3;
              Console.WriteLine($"local variable {nameof(no2)} after the change: {no2}");
              Console.WriteLine("Press any key to Exit.");
              Console.ReadLine();
          }
          */
        //Ref Returns in C#
        public ref int GetFirstOddNumber(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    return ref numbers[i]; //returning as reference  
                }
            }
            throw new Exception("odd number not found");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] x = { 2, 4, 62, 54, 33, 55, 66, 71, 92 };
            ref int oddNum = ref p.GetFirstOddNumber(x); //storing as reference  
            Console.WriteLine($"\t\t{oddNum}");
            oddNum = 35;
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"{x[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
    
}
 