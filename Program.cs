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
 //Ref Local in C#
}

}
 