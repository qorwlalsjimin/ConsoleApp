using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("메서드 호출");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("메서드 호출2");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("메서드 호출3");
        }
    }
}
