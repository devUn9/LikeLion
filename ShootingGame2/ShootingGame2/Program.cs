using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame2
{
    struct Player
    {
        public int X;
        public int Y;
        public string[] Shape;

        //생성자 정의, 처음 생성할 때 동작하는 함수
        public Player(int a, int b)
        {
            X = a;
            Y = b;
            Shape = new string[] { "->", ">>>", "->" };
        }

        //이동
        public void Move(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow: if (Y > 0) Y--; break;
                case ConsoleKey.DownArrow: if (Y < Console.WindowHeight - 5) Y++; break;
                case ConsoleKey.LeftArrow: if (X > 0) X--; break;
                case ConsoleKey.RightArrow: if (X < Console.WindowWidth - 5) X++; break;
                case ConsoleKey.Spacebar: Attack(); break;
            }
        }

        //출력
        public void Draw()
        {
            for (int i = 0; i < Shape.Length; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.WriteLine(Shape[i]);
            }
        }
        public void Attack()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevTime = stopwatch.ElapsedMilliseconds;
            int attackX = X; // 공격 시작 위치

            while (attackX < Console.WindowWidth) // 콘솔 끝까지
            {
                long currentTime = stopwatch.ElapsedMilliseconds;

                if (currentTime - prevTime >= 10) // 50ms마다 갱신
                {
                    Console.Clear();
                    Draw(); // 플레이어 다시 그리기

                    Console.SetCursorPosition(attackX, Y + 1);
                    Console.Write("◎"); // 공격 표시

                    attackX++; // 공격 위치 이동
                    prevTime = currentTime; // 이전 시간 업데이트
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;

            // 플레이어 초기화
            Player player = new Player(10, 10);

            // 타이머 설정
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long prevSecond = stopwatch.ElapsedMilliseconds;

            // 게임 루프
            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds;
                if (currentSecond - prevSecond >= 10)
                {
                    Console.Clear(); // 화면 지우기

                    // 키 입력 처리
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true); // 키 입력 받기
                        if (keyInfo.Key == ConsoleKey.Escape) return; // ESC키로 종료
                        player.Move(keyInfo.Key); // 키에 따라 플레이어 이동
                        
                    }

                    // 플레이어 그리기
                    player.Draw();

                    prevSecond = currentSecond; // 이전 시간 업데이트
                }
            }
        }
    }
}