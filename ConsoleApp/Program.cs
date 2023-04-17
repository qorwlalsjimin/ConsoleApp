using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp
{
    internal class Program
    {
        private static readonly int SnakeStateTotal = 3;
        private const int SnakeState1 = 0;
        private const int SnakeState2 = 1;
        private const int SnakeState3 = 2;
        private static readonly int SnakeMoveCount = 50;
        private static readonly int SnakeRow = 5;
        private static readonly int SnakeSleepTime = 1000;

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

            int x = SnakeState1;
            while(x < SnakeMoveCount)
            {
                Console.Clear();
                Console.SetCursorPosition(x, SnakeRow); //매직넘버

                switch (x % SnakeStateTotal)
                {
                    case SnakeState1:
                        Console.WriteLine("__@");
                        break;
                    case SnakeState2:
                        Console.WriteLine("_^@");
                        break;
                    case SnakeState3:
                        Console.WriteLine("^_@");
                        break;

                }
                Thread.Sleep(SnakeSleepTime);
                x++;
            }
        }
    }
}
