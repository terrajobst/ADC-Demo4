using System;
using System.Collections;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.WindowWidth);

            IList list = new ArrayList();
            list.Add(1);
            list.Add("two");
        }
    }
}
