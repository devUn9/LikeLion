using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            //int x = 10, y = 10;
            //Console.Write("●"); // 현재 위치 출력

            ConsoleKeyInfo keyInfo;
            Console.CursorVisible = false;

            string[] player = new string[]
                {
                    "->",
                    ">>>",
                    "->"
                };
            int playerX = 0;
            int playerY = 12;

            //시간 1초 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1/1000초, 1000일때 1초

            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; // 현재시간 가져오기
                
                if (currentSecond - prevSecond >= 10)
                {
                    Console.Clear();

                    if (Console.KeyAvailable)
                    {
                        keyInfo = Console.ReadKey(true); // 키 입력받기 (화면 출력x)
                        Console.SetCursorPosition(playerX + 3, playerY + 1);
                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                            case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 5) playerY++; break;
                            case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                            case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 5) playerX++; break;
                            case ConsoleKey.Spacebar: Console.Write("---"); break;
                            case ConsoleKey.Escape: return; // ESC키로 종료

                                
                        }
                    }
                        
                    
                    
                    
                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이터 X 플레이어 Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열 배열 출력
                        Console.WriteLine(player[i]);
                        
                    }

                    prevSecond = currentSecond; //이전시간 업데이트
                
                }
            }

        }
    }
}
