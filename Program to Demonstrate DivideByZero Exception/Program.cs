using System;
class Program
{
    static void Main()///This C# program is used to demonstrate DivideByZero exception. In try statement using ‘result’ variable divide the value of 15 by 0, here a DivideByZero exception is thrown. It indicates that a statement attempted to evaluate a division by zero. Using try and catch, an error message is displayed when the error occurs.////
    {
        try
        {
            int result = 15 / int.Parse("0");
            Console.WriteLine(result);
        }
        catch (DivideByZeroException e)
        {
            Console.Write(e.Message);
            Console.ReadLine();
        }
    }
}
///Output: Attempted to Divide by Zero