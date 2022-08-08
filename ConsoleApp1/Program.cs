using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "savva";
            name.Increment();
            Console.WriteLine(name);
        }
        
    }
    public static class MyHelper
    {
        public static void Increment(this string s)
        {
            s = "irma";
        }
    }
}
