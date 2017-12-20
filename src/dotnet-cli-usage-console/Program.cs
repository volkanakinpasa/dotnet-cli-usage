using System;
using dotnet_cli_usage_class_lib;

namespace dotnet_cli_usage_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Class1 class1 = new Class1();
            System.Console.WriteLine(class1.Message);
        }
    }
}
