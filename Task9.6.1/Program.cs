using System;
using System.IO;
using Task9._6._1;

Exception[] exceptions = new Exception[5];
exceptions[0] = new DivideByZeroException();
exceptions[1] = new MyException("Some exception!"); //My exception!
exceptions[2] = new OverflowException();
exceptions[3] = new TimeoutException();
exceptions[4] = new DivideByZeroException();


for (int i = 0; i < exceptions.Length; i++)
{
    try
    {
        throw exceptions[i];
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
    }
}