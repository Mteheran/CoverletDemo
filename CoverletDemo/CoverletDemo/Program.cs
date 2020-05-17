using System;
using System.Diagnostics.CodeAnalysis;

namespace CoverletDemo
{
    //[ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            if(DateTime.Now.Hour>0)
            {
                Console.WriteLine("Hello World!");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
