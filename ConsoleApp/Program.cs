using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*            Console.Write("메서드 호출");
            Thread.Sleep(1000); //1초 //Thread 문제로 정확하지 않다
            Console.SetCursorPosition(5, 5); //화면 표시는 절댓값
            Console.WriteLine("메서드 호출2");
            Thread.Sleep(2000); //2초
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("메서드 호출3");

            //Console.SetCursorPosition(0, 0); //위에 출력 내용을 덮을 수 있다*/

            int x = 1;
            while(x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                switch (x % 3)
                {
                    case 0:
                        Console.WriteLine("__@");
                        break;
                    case 1:
                        Console.WriteLine("_^@");
                        break;
                    case 2:
                        Console.WriteLine("^_@");
                        break;

                }
                Thread.Sleep(1000);
                x++;
            }
        }
    }
}
