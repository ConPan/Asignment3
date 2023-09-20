// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void MyThirdMethod(string message)
    {
        Console.WriteLine(message);
        string userName = Console.ReadLine();
        Console.WriteLine(userName);
    }

    static void Main(string[] args)
    {
        MyThirdMethod("Please enter a number");
    }
}





