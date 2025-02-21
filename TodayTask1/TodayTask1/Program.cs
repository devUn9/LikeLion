using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace TodayTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //로딩바 시작화면
            //게임 스토리1
            
            Console.WriteLine("엔터를 누르면 스토리가 진행됩니다.");
            Console.Write("\n▶ 시작한다");


            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("□□□□□□□□");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("■□□□□□□□");
            Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("■■□□□□□□");
            Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("■■■□□□□□");
            Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("■■■■□□□□");
            Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("■■■■■□□□");
            Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("■■■■■■□□");
            Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("■■■■■■■□");
            Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("■■■■■■■■");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("당신은 지루하다..");
            Console.WriteLine("\n▶ 산책을 나선다.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("앞에서 무슨 소리가 들린다.");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("냐...");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("냐옹.....");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("냐아아옹~~~~");
            Thread.Sleep(1000);
            Console.Clear();


            Console.WriteLine(" /\\_/\\  \r\n( -_- )  \r\n /     \\  \r\n(________)  ");
            Console.WriteLine("야생의 고양이를 발견했다!");

            Console.WriteLine("\n▶ 츄르를 준다.");
            Console.ReadLine();



            string[] catFrames = new string[]
        {
            @" /\_/\
( o.o )
 > ^  <
(_______)
고양이가 기뻐한다!",
            @" /\_/\ 
( o.o ) 
 < ^  >  
(_______)
고양이가 기뻐한다!",
            @" /\_/\  
( o.o )  
 > ~  <  
(_______)
고양이가 기뻐한다!"

        };

            while (true)
            {
                foreach (string frame in catFrames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Thread.Sleep(500); // 0.5초마다 변경
                }
            }

            Console.WriteLine("냐옹!");

        }
    }
}
