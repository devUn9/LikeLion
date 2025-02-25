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
            string[] options = { "새 게임", "이어하기", "설정", "종료" };
            int selectedIndex = 0;
            int option = 0;
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                Console.Clear(); // 화면을 지움
                Console.WriteLine("메뉴를 선택하세요 (↑↓ 이동, Enter 선택)\n");

                // 선택지를 출력
                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; // 선택된 항목 강조
                        Console.WriteLine($"> {options[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {options[i]}  ");
                    }
                }

                keyInfo = Console.ReadKey(true); // 키 입력 받기 (true = 화면에 입력 안 보이게)

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:    // 위 방향키
                        selectedIndex = (selectedIndex == 0) ? options.Length - 1 : selectedIndex - 1;
                        break;
                    case ConsoleKey.DownArrow:  // 아래 방향키
                        selectedIndex = (selectedIndex == options.Length - 1) ? 0 : selectedIndex + 1;
                        break;
                    case ConsoleKey.Enter:      // 엔터 키
                        Console.Clear();

                        StartGame();
                        return ; // 프로그램 종료 또는 다음 로직 실행
                }
            }

            void StartGame()
            {
                //로딩바 시작화면
                //게임 스토리1

                Console.WriteLine("엔터를 누르면 스토리가 진행됩니다.");
                Console.Write("\n▶ 시작한다");


                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("□□□□□□□□\n불러오는중");
                Thread.Sleep(2000);
                Console.Clear();

                Console.WriteLine("■□□□□□□□\n불러오는중.");
                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("■■□□□□□□\n불러오는중..");
                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("■■■□□□□□\n불러오는중...");
                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("■■■■□□□□\n불러오는중");
                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("■■■■■□□□\n불러오는중.");
                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("■■■■■■□□\n불러오는중..");
                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("■■■■■■■□\n불러오는중...");
                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("■■■■■■■■\n불러오기 완료!");
                Thread.Sleep(1500);
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
                //            //로딩바 시작화면
                //            //게임 스토리1

                //            Console.WriteLine("엔터를 누르면 스토리가 진행됩니다.");
                //            Console.Write("\n▶ 시작한다");


                //            Console.ReadLine();

                //            Console.Clear();
                //            Console.WriteLine("□□□□□□□□\n불러오는중");
                //            Thread.Sleep(2000);
                //            Console.Clear();

                //            Console.WriteLine("■□□□□□□□\n불러오는중.");
                //            Thread.Sleep(100);
                //            Console.Clear();

                //            Console.WriteLine("■■□□□□□□\n불러오는중..");
                //            Thread.Sleep(100);
                //            Console.Clear();

                //            Console.WriteLine("■■■□□□□□\n불러오는중...");
                //            Thread.Sleep(100);
                //            Console.Clear();

                //            Console.WriteLine("■■■■□□□□\n불러오는중");
                //            Thread.Sleep(100);
                //            Console.Clear();

                //            Console.WriteLine("■■■■■□□□\n불러오는중.");
                //            Thread.Sleep(100);
                //            Console.Clear();

                //            Console.WriteLine("■■■■■■□□\n불러오는중..");
                //            Thread.Sleep(100);
                //            Console.Clear();

                //            Console.WriteLine("■■■■■■■□\n불러오는중...");
                //            Thread.Sleep(100);
                //            Console.Clear();

                //            Console.WriteLine("■■■■■■■■\n불러오기 완료!");
                //            Thread.Sleep(1500);
                //            Console.Clear();

                //            Console.WriteLine("당신은 지루하다..");
                //            Console.WriteLine("\n▶ 산책을 나선다.");
                //            Console.ReadLine();
                //            Console.Clear();

                //            Console.WriteLine("앞에서 무슨 소리가 들린다.");
                //            Thread.Sleep(1000);
                //            Console.Clear();

                //            Console.WriteLine("냐...");
                //            Thread.Sleep(1000);
                //            Console.Clear();

                //            Console.WriteLine("냐옹.....");
                //            Thread.Sleep(1000);
                //            Console.Clear();

                //            Console.WriteLine("냐아아옹~~~~");
                //            Thread.Sleep(1000);
                //            Console.Clear();


                //            Console.WriteLine(" /\\_/\\  \r\n( -_- )  \r\n /     \\  \r\n(________)  ");
                //            Console.WriteLine("야생의 고양이를 발견했다!");

                //            Console.WriteLine("\n▶ 츄르를 준다.");
                //            Console.ReadLine();



                //            string[] catFrames = new string[]
                //        {
                //            @" /\_/\
                //( o.o )
                // > ^  <
                //(_______)
                //고양이가 기뻐한다!",
                //            @" /\_/\ 
                //( o.o ) 
                // < ^  >  
                //(_______)
                //고양이가 기뻐한다!",
                //            @" /\_/\  
                //( o.o )  
                // > ~  <  
                //(_______)
                //고양이가 기뻐한다!"

                //        };

                //            while (true)
                //            {
                //                foreach (string frame in catFrames)
                //                {
                //                    Console.Clear();
                //                    Console.WriteLine(frame);
                //                    Thread.Sleep(500); // 0.5초마다 변경
                //                }
                //            }

                //            Console.WriteLine("냐옹!");

                //        }
            }
}
