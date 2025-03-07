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

            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.White;

            Random rand = new Random();
            int level = 1;
            int gold = 0;
            int health = 10;
            int power = 10;

            int enforcelevel = 1;
            int evolutionlevel = 1;

            int minusprob = 0;


            int x = 1;
            int y = 6;

            int expense = 100;
            int expense2 = 50;


            string catname = "냥냥이";
            string skillname = "냥냥펀치";

            bool enforcesuccess = false;
            //bool isAlive = true;

            init();

            Console.CursorVisible = false;


            void init()
            {
                Console.Clear();

                string[] options = { "모험하기\n", "캣타워\n", "생선가게\n", "게임종료\n" };
                int selectedIndex = 0;

                ConsoleKeyInfo keyInfo;

                while (true)
                {
                    Console.Clear(); // 화면을 지움
                    Console.WriteLine("\n 캣월드에 오신것을 환영합니다 ! \n\n (↑↓ 방향키 이동, SPACE 선택)");

                    Console.SetCursorPosition(0, 15);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n\n");
                    Console.ForegroundColor = ConsoleColor.White;


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

            void Ganghwa()
            {
                Console.Clear();




                string[] options = { "강화하기\n", "진화하기\n", "뒤로\n" };
                int selectedIndex = 0;

                ConsoleKeyInfo keyInfo;

                while (true)
                {
                    Console.Clear(); // 화면을 지움

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($" 레벨 {level} {catname} ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($" 체력 {health} ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($" 공격력 {power} ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($" 골드 {gold}\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n <캣타워> 에서는 고양이를 성장시킬 수 있습니다. \n");

                    switch (catname)
                    {
                        case "냥냥이":

                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine(@"  /\_/\ ");
                            Console.WriteLine(@" ( o.o )");
                            Console.WriteLine(@" <  ^   > /");
                            Console.WriteLine(@" (______)/");

                            Console.ForegroundColor = ConsoleColor.White;

                            break;

                        case "킹냥이":

                            Console.ForegroundColor = ConsoleColor.DarkYellow;

                            Console.WriteLine(@"  /フ_/フ ");
                            Console.WriteLine(@" ( >.< )");
                            Console.WriteLine(@" <  ^   > /");
                            Console.WriteLine(@" (______)/");

                            Console.ForegroundColor = ConsoleColor.White;

                            break;
                    }

                    Console.WriteLine($"\n 강화 확률 : {100 - minusprob} %");
                    Console.WriteLine($" 강화 골드 : {expense} 골드");

                    Console.WriteLine("\n 레벨이 5일 때 진화시킬 수 있습니다.");

                    Console.SetCursorPosition(0, 15);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n\n");
                    Console.ForegroundColor = ConsoleColor.White;

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

                            Menu2(selectedIndex);
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
                        Ganghwa();

                        break;
                    case 2: // "생선 가게"
                        shop();

                        break;
                    case 3: // "나가기"
                        Console.WriteLine("\n 게임을 종료합니다! \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                        Environment.Exit(1);
                        break;
                    
                }
            }

            void Menu2(int selected)
            {
                switch (selected)
                {
                    case 0: // "강화하기"
                        if (gold >= expense)
                        {
                            Enforce();
                        }
                        else
                        {
                            Ganghwa();
                        }

                        break;
                    case 1: // "진화하기"
                        Evolution();

                        break;
                    case 2: // 뒤로
                        init();
                        break;
                        

                }
            }

            void Menu3(int selected)
            {
                switch (selected)
                {
                    case 0: // "생선 구매"
                        if (gold >= expense2)
                        {
                            Buyfish();
                        }
                        else
                        {
                            shop();
                        }

                        break;
                    case 1: // "츄르 구매"
                        if (gold >= expense2 * 3)
                            Buychur();
                        else
                        {
                            shop();
                        }

                        break;
                    case 2:
                        init();
                        break;
 
                }
            }

            void Buyfish()
            {
                gold -= 50;
                BuyfishAnim();
                shop();
            }
            void Buychur()
            {
                gold -= 150;
                BuychurAnim();
                shop();
            }

            void BuyfishAnim()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n  >< (((°>");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n   \\(^)/");
                Thread.Sleep(500);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n  >< (((°>");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n \\\\((^))//");
                Thread.Sleep(500);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n  >< (((°>");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n   \\(^)/");
                Thread.Sleep(500);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n  >< (((°>");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n \\\\((^))//");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(500);

                Console.WriteLine($"\n 생선구이 구매에 성공했습니다 !");

                health += 5;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n 체력 : {health} (+ 5)");

                Thread.Sleep(2000);

            }

            void BuychurAnim()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n |￣￣￣￣￣￣￣￣￣￣￣￣￣￣|");
                Console.WriteLine(" |         >< (((°>          |");
                Console.WriteLine(" |＿＿＿＿＿＿＿＿＿＿＿＿＿＿|");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(500);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n |￣￣￣￣￣￣￣￣￣￣￣￣￣￣|");
                Console.WriteLine(" |         >< (((°>          |");
                Console.WriteLine(" |＿＿＿＿＿＿＿＿＿＿＿＿＿＿/");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(500);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n |￣￣￣￣￣￣￣￣￣￣￣￣￣￣|");
                Console.WriteLine(" |         >< (((°>          /");
                Console.WriteLine(" |＿＿＿＿＿＿＿＿＿＿＿＿＿＿/");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(500);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n |￣￣￣￣￣￣￣￣￣￣￣￣￣￣/");
                Console.WriteLine(" |         >< (((°>         /");
                Console.WriteLine(" |＿＿＿＿＿＿＿＿＿＿＿＿＿/");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(500);

                Console.WriteLine($"\n 생선츄르 구매에 성공했습니다 !");

                health += 15;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n 체력 : {health} (+ 10)");
                Thread.Sleep(2000);

            }

            void Advanture()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" 레벨 {level} {catname} ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($" 체력 {health} ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($" 공격력 {power} ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($" 골드 {gold}\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n 모험을 시작합니다.");
                Thread.Sleep(1000);

                Console.WriteLine($"\n 가라 {catname} ! \n");
                Thread.Sleep(1000);

                switch (catname)
                {
                    case "냥냥이":

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(@"  /\_/\ ");
                        Console.WriteLine(@" ( o.o )");
                        Console.WriteLine(@" <  ^   > /");
                        Console.WriteLine(@" (______)/");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1000);
                        break;

                    case "킹냥이":

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(@"  /フ_/フ ");
                        Console.WriteLine(@" ( o.o )");
                        Console.WriteLine(@" <  ^   > /");
                        Console.WriteLine(@" (______)/");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1000);
                        break;
                }

                int eventChance = rand.Next(1, 101); // 1~100 정수 발생

                if (eventChance <= 50) // 50% 확률로 전투 발생
                {
                    int monsterhealth = rand.Next(x, y);    // 몬스터 체력 초기값 1~5

                    int damage = rand.Next(x, y);   // 몬스터 공격력 초기값 1~5

                    Console.Write("\n 체력이");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($" {monsterhealth} ");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("공격력이");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($" {damage}");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("인 몬스터를 만났습니다! \n");

                    Thread.Sleep(2000);

                    x += 3; y += 3; // 점점 랜덤 값이 증가

                    if (power >= monsterhealth) // 고양이의 공격력이 몬스터의 체력보다 크거나 같을 때
                    {

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.WriteLine($"\n {catname}의 {skillname} ! ");

                        Thread.Sleep(1000);

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"\n {power}의 데미지를 입혀 몬스터를 쓰러뜨렸습니다 !");

                        int reward = rand.Next(150 + x * 10, 300 + y * 10); // 150 ~ 300 골드, 점점 보상 증가
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($" 골드 +{reward}\n");
                        gold += reward;

                        Thread.Sleep(2000);
                    }
                    else // 몬스터 체력이 고양이의 공격력보다 클 때
                    {
                        Console.Write($"\n 몬스터에게 공격 당했습니다 !");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($" 체력 -{damage}\n");
                        health -= damage;

                        Thread.Sleep(2000);
                    }

                }
                else if (eventChance <= 75)
                {
                    int reward = rand.Next(100, 301); // 100~300 골드 보물 발견

                    Console.Write("\n 보물을 발견했습니다 !");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($" 골드 +{reward}\n");

                    gold += reward;

                    Thread.Sleep(2000);
                }
                else
                {
                    int heal = rand.Next(5, 10); // 10~30 체력 회복
                    Console.Write($"\n 생선을 발견했습니다 !");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($" 체력 +{heal}\n");
                    health += heal;

                    Thread.Sleep(2000);
                }

                if (health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n 체력이 0이 되어 쓰러졌습니다... 게임 오버!\n");
                    Thread.Sleep(3000);
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

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($" 레벨 {level} {catname} ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($" 체력 {health} ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($" 공격력 {power} ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($" 골드 {gold}\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n <생선가게> 에서는 생선을 구매할 수 있습니다. \n");



                    Console.Write("\n 생선구이는 5의 체력을 올려줍니다.");
                    Console.WriteLine($"\n 가격 : 50 골드");

                    Console.Write("\n 생선츄르는 15의 체력을 올려줍니다.");
                    Console.WriteLine($"\n 가격 : 150 골드");




                    Console.SetCursorPosition(0, 15);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n\n");
                    Console.ForegroundColor = ConsoleColor.White;

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

                            Menu3(selectedIndex);
                            return; // 프로그램 종료 또는 다음 로직 실행


                    }
                }
            }

            void EnforceAnim(int e)
            {
                if (evolutionlevel == 1)
                {
                    if (enforcesuccess)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(@"  /\_/\ ");
                        Console.WriteLine(@" ( o.o )");
                        Console.WriteLine(@" <  ^   > /");
                        Console.WriteLine(@" (______)/");
                        Thread.Sleep(500);
                        Console.Clear();

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(@"  /\_/\ ");
                        Console.WriteLine(@" ( o.o )");
                        Console.WriteLine(@" >  ^   < /");
                        Console.WriteLine(@" (______)/");
                        Thread.Sleep(500);
                        Console.Clear();

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(@"  /\_/\ ");
                        Console.WriteLine(@" ( >.< )");
                        Console.WriteLine(@" <  ^   > /");
                        Console.WriteLine(@" (______)/");


                        Console.WriteLine($"\n 레벨 {e} 강화에 성공했습니다 !");

                        power += 5;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"\n 공격력 : {power} (+ 5)");


                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(@"  /\_/\ ");
                        Console.WriteLine(@" ( o.o )");
                        Console.WriteLine(@" <  ^   > /");
                        Console.WriteLine(@" (______)/");
                        Thread.Sleep(500);
                        Console.Clear();

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(@"  /\_/\ ");
                        Console.WriteLine(@" ( o.o )");
                        Console.WriteLine(@" >  ^   < /");
                        Console.WriteLine(@" (______)/");
                        Thread.Sleep(500);
                        Console.Clear();

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(@"  /\_/\ ");
                        Console.WriteLine(@" (ㅠ.ㅠ )");
                        Console.WriteLine(@" <  ^   > /");
                        Console.WriteLine(@" (______)/");


                        Console.WriteLine($"\n 레벨 {e + 1} 강화에 실패했습니다 !");
                        Thread.Sleep(1500);
                    }


                }

            }

            void EvolutionAnim()
            {
                if (catname == "냥냥이")
                {
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(@"  /\_/\ ");
                    Console.WriteLine(@" ( o.o )");
                    Console.WriteLine(@" <  ^   > /");
                    Console.WriteLine(@" (______)/");
                    Thread.Sleep(500);
                    Console.Clear();

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(@"  /\_/\ ");
                    Console.WriteLine(@" ( o.o )");
                    Console.WriteLine(@" >  ^   < /");
                    Console.WriteLine(@" (______)/");
                    Thread.Sleep(500);
                    Console.Clear();

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(@"  /\_/\ ");
                    Console.WriteLine(@" ( o.o )");
                    Console.WriteLine(@" <  ^   > /");
                    Console.WriteLine(@" (______)/");

                    Console.WriteLine($"\n {catname}의 상태가.");
                    Thread.Sleep(500);
                    Console.Clear();

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(@"  /\_/\ ");
                    Console.WriteLine(@" ( o.o )");
                    Console.WriteLine(@" <  ^   > /");
                    Console.WriteLine(@" (______)/");

                    Console.WriteLine($"\n {catname}의 상태가..");
                    Thread.Sleep(500);
                    Console.Clear();

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(@"  /\_/\ ");
                    Console.WriteLine(@" ( o.o )");
                    Console.WriteLine(@" <  ^   > /");
                    Console.WriteLine(@" (______)/");

                    Console.WriteLine($"\n {catname}의 상태가...");
                    Thread.Sleep(500);
                    Console.Clear();

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(@"  /\_/\ ");
                    Console.WriteLine(@" ( o.o )");
                    Console.WriteLine(@" <  ^   > /");
                    Console.WriteLine(@" (______)/");

                    Console.WriteLine($"\n {catname}의 상태가...?");
                    Thread.Sleep(500);
                    Console.Clear();

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(@"  /フ_/フ ");
                    Console.WriteLine(@" ( o.o )");
                    Console.WriteLine(@" <  ^   > /");
                    Console.WriteLine(@" (______)/");

                    Console.WriteLine($"\n {catname}의 상태가...?");
                    Thread.Sleep(500);
                    Console.Clear();

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(@"  /\_/\ ");
                    Console.WriteLine(@" ( o.o )");
                    Console.WriteLine(@" <  ^   > /");
                    Console.WriteLine(@" (______)/");

                    Console.WriteLine($"\n {catname}의 상태가...?");
                    Thread.Sleep(1000);
                    Console.Clear();

                    Console.WriteLine();
                    Console.WriteLine(@"  /フ_/フ ");
                    Console.WriteLine(@" ( o.o )");
                    Console.WriteLine(@" <  ^   > /");
                    Console.WriteLine(@" (______)/");

                    Console.WriteLine($"\n {catname}의 상태가...?");
                    Thread.Sleep(2000);
                    Console.Clear();

                    catname = "킹냥이";
                    skillname = "고속냥냥펀치";

                    power += 30;
                    level = 1;


                    Console.WriteLine();
                    Console.WriteLine(@"  /フ_/フ ");
                    Console.WriteLine(@" ( >.< )");
                    Console.WriteLine(@" <  ^   > /");
                    Console.WriteLine(@" (______)/");
                    Console.Write($"\n {catname}로 진화했습니다 ! ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($" 공격력 : {power} (+ 30)\n");


                    Thread.Sleep(3000);

                    Ganghwa();
                }
            }

            void Enforce()
            {
                int number = rand.Next(1, 101); // 1~100

                if (level < 5)
                {

                    if (number > minusprob)
                    {

                        enforcesuccess = true;

                        gold -= expense;
                        level += 1;
                        expense += 100;

                        EnforceAnim(level);

                        minusprob += 10;
                        Ganghwa();


                    }
                    else
                    {
                        enforcesuccess = false;
                        gold -= expense;


                        EnforceAnim(level);

                        Ganghwa();

                    }

                }
                else
                {
                    Ganghwa();
                }

            }

            void Evolution()
            {
                if (level == 5)
                {

                    EvolutionAnim();

                }
                else
                {
                    Ganghwa();
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