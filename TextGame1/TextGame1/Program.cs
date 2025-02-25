using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            //콘솔 창 크기 설정
            Console.SetWindowSize(81, 26);

            //콘솔 버퍼 크기도 설정
            Console.SetBufferSize(81, 26);

            //Console.WriteLine("콘솔 창 크기가 80x25로 설정되었습니다.");
            //Console.ReadLine();

            //Console.Title = "멋사콘솔게임만들기";
            //Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = false;
            Console.Clear();


            //Console.SetCursorPosition(40, 12);
            //Console.Write("대장장이키우기");
            //Thread.Sleep(5000);

            Console.SetCursorPosition(0, 0);
            Console.Write("┎━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┒");
            Console.SetCursorPosition(0, 1);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 2);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 3);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 5);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 6);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 7);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 8);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 9);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 10);
            Console.Write("┃                   __   _   ___  _ _ _   _   ___  _    __                     ┃");
            Console.SetCursorPosition(0, 11);
            Console.Write("┃                  / _| / \\ |_ _|| | | | / \\ | o \\| |  |  \\                    ┃");
            Console.SetCursorPosition(0, 12);
            Console.Write("┃                 ( (_ | o | | | | V V |( o )|   /| |_ | o )                   ┃");
            Console.SetCursorPosition(0, 13);
            Console.Write("┃                  \\__||_n_| |_|  \\_n_/  \\_/ |_|\\\\|___||__/                    ┃");
            Console.SetCursorPosition(0, 14);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 15);
            Console.Write("┃                               L I K E L I O N                                ┃");
            Console.SetCursorPosition(0, 16);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 17);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 20);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 21);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 22);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 23);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 24);
            Console.Write("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.White;

            Random rand = new Random();
            int gold = 1000;
            int health = 100;
            int power = 10;
            string catname = "냥냥이";
            //bool isAlive = true;

            init();

            void init()
            {
                Console.Clear();

                string[] options = { "모험하기\n", "캣타워\n", "생선가게\n", "게임종료\n" };
                int selectedIndex = 0;

                ConsoleKeyInfo keyInfo;

                while (true)
                {
                    Console.Clear(); // 화면을 지움
                    Console.WriteLine("\n 캣월드에 오신것을 환영합니다 ! \n\n (↑↓ 방향키 이동, SPACE 선택)\n");

                    // 선택지를 출력
                    for (int i = 0; i < options.Length; i++)
                    {
                        if (i == selectedIndex)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow; // 선택된 항목 강조
                            Console.WriteLine($" > {options[i]}");
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
                        case ConsoleKey.Spacebar:      // 스페이스바 키
                            Console.Clear();

                            Menu(selectedIndex);
                            return; // 프로그램 종료 또는 다음 로직 실행
                    }
                }
            }

            void ganghwa()
            {
                Console.Clear();

                string[] options = { "강화하기\n", "진화하기\n", "뒤로\n" };
                int selectedIndex = 0;

                ConsoleKeyInfo keyInfo;

                while (true)
                {
                    Console.Clear(); // 화면을 지움
                    Console.WriteLine("\n 이곳에서는 고양이를 성장시킬 수 있습니다 ! \n");

                    // 선택지를 출력
                    for (int i = 0; i < options.Length; i++)
                    {
                        if (i == selectedIndex)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow; // 선택된 항목 강조
                            Console.WriteLine($" > {options[i]}");
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
                        case ConsoleKey.Spacebar:      // 스페이스바 키
                            Console.Clear();

                            init();
                            return; // 프로그램 종료 또는 다음 로직 실행
                    }
                }
            }


            void Menu(int selected)
            {
                switch (selected)
                {
                    case 0: // "모험하기"

                        Advanture();
                        break;
                    case 1: // "고양이 진화"
                        ganghwa();

                        break;
                    case 2: // "생선 가게"
                        shop();

                        break;
                    case 3: // "나가기"
                        Console.WriteLine("\n 게임을 종료합니다! \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다.");
                        break;
                }
            }

            void Advanture()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($" 체력 {health} ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($" 공격력 {power} ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($" 골드 {gold}\n");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n 모험을 시작합니다.");
                Thread.Sleep(1000);

                Console.WriteLine($"\n 가자 {catname} ! \n");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(@"  /\_/\ ");
                Console.WriteLine(@" ( o.o )");
                Console.WriteLine(@" <  ^   > /");
                Console.WriteLine(@" (______)/");
                Console.ForegroundColor = ConsoleColor.White;

                Thread.Sleep(1000);

                int eventChance = rand.Next(1, 101); // 1~100 랜덤 이벤트 발생 //// 확률 바꿔놓음!!!!!!!!!!!

                if (eventChance <= 45) // 30%확률로 전투 발생
                {
                    int damage = rand.Next(200, 300);
                    Console.Write($"\n 괴물 쥐를 만났습니다...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($" 체력 -{damage}\n");
                    health -= damage;

                    Thread.Sleep(1000);

                }
                else if (eventChance <= 50)
                {
                    int reward = rand.Next(100, 301); // 100~300 골드
                    Console.WriteLine($" 보물을 발견했습니다 ! (골드 +{reward})");
                    gold += reward;
                }
                else
                {
                    int heal = rand.Next(10, 31); // 10~30 체력 회복
                    Console.Write($"\n 생선을 발견했습니다 !");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($" 체력 +{heal}\n");
                    health += heal;

                    Thread.Sleep(1000);
                }

                if (health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n 체력이 0이 되어 쓰러졌습니다... 게임 오버!\n");
                    Thread.Sleep(1000);
                    //isAlive = false;// 아직 안쓰임
                    GameOver();
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\n 돌아와 {catname} !");

                Thread.Sleep(2000);

                init();
            }


            void shop()
            {
                Console.Clear();

                string[] options = { "생선구이 구매\n", "생선츄르 구매\n", "뒤로\n" };
                int selectedIndex = 0;

                ConsoleKeyInfo keyInfo;

                while (true)
                {
                    Console.Clear(); // 화면을 지움
                    Console.WriteLine("\n 이곳에서는 생선을 살 수 있습니다 ! \n");

                    // 선택지를 출력
                    for (int i = 0; i < options.Length; i++)
                    {
                        if (i == selectedIndex)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow; // 선택된 항목 강조
                            Console.WriteLine($" > {options[i]}");
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
                        case ConsoleKey.Spacebar:      // 스페이스바 키
                            Console.Clear();

                            init();
                            return; // 프로그램 종료 또는 다음 로직 실행
                    }
                }
            }
            void GameOver()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(0, 0);
                Console.Write("┎━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┒");
                Console.SetCursorPosition(0, 1);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 2);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 3);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 4);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 5);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 6);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 7);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 8);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 9);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 10);
                Console.Write("┃                    __   _   _   _  ___    _   _ _  ___  ___                  ┃");
                Console.SetCursorPosition(0, 11);
                Console.Write("┃                   / _| / \\ | \\_/ || __|  / \\ | | || __|| o \\                 ┃");
                Console.SetCursorPosition(0, 12);
                Console.Write("┃                  ( |_n| o || \\_/ || _|  ( o )| V || _| |   /                 ┃");
                Console.SetCursorPosition(0, 13);
                Console.Write("┃                   \\__/|_n_||_| |_||___|  \\_/  \\_/ |___||_|\\\\                 ┃");
                Console.SetCursorPosition(0, 14);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 15);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 16);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 17);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 18);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 19);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 20);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 21);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 22);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 23);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 24);
                Console.Write("┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                Thread.Sleep(3000);
                Environment.Exit(1);
            }
        }
       



    }
}

