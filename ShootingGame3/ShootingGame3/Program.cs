using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame3
{

    //미사일 클래스
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }
    //플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")] // c언어 함수 가져옴
        static extern int _getch();

        public int playerX; // 플레이어 X좌표
        public int playerY; // 플레이어 Y좌표
        public BULLET[] playerBullet = new BULLET[20];

        public Player() // 생성자
        {
            //플레이어 좌표 위치 초기화
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++) // 총알 초기화
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;
            }
        }
        public void GameMain()
        {
            //키를 입력하는 부분
            KeyControl();
            PlayerDraw();

        }

        public void KeyControl()
        {
            const int UPKEY = 72;
            const int LEFTKEY = 75;
            const int RIGHTKEY = 77;
            const int DOWNKEY = 80;
            const int SPACEBAR = 32;

            int pressKey; // 정수형 변수선언 키 값 받을거임

            if (Console.KeyAvailable)
            {
                pressKey = _getch(); // 아스키값 왼쪽 오른쪽

                switch (pressKey)
                {
                    case UPKEY: //위쪽 방향 아스키 코드
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case LEFTKEY: //왼쪽 방향 아스키 코드
                        playerX--;
                        if (playerX < 0)
                            playerX = 0;
                        break;
                    case RIGHTKEY: //오른쪽 방향 아스키 코드
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;
                    case DOWNKEY: //아래쪽 방향 아스키 코드
                        playerY++;
                        if (playerY > 22)
                            playerY = 22;
                        break;
                    case SPACEBAR: //스페이스바 아스키 코드
                        //총알 발사
                        for (int i = 0; i < 20; i++)
                        {

                            //미사일이 false발사 가능
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].x = playerY + 1;
                                //한발씩 쏘겠다
                                break;
                            }
                        }
                        break;
                }
            }

        }

        public void PlayerDraw()
        {
            String[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; //문자열 배열로 그리기
            
            for (int i=0;i<player.Length;i++)
            {
                //콘솔좌표 설정 플레이어 X 플레이어 Y
                Console.SetCursorPosition(playerX, playerY + i);
                //문자열배열 출력
                Console.WriteLine(player[i]);
            }
        }
        //미사일 그리기
        public void BulletDraw()
        {
            string bullet = "->"; //미사일 모습
            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태면
                if (playerBullet[i].fire == true)
                {
                    //좌표 설정, 보정
                    Console.SetCursorPosition(playerBullet[i].x, playerBullet[i].y);
                    //총알 출력
                    Console.Write(bullet);
                    playerBullet[i].x++; // 미사일 오른쪽으로 날아가기
                    if (playerBullet[i].x > 78)
                    {
                        playerBullet[i].fire = false;
                    }
                }
            }
        }

        //충돌 처리
        public void ClashEnemyAndBullet(Enemy enemy)
        {

        }


    }

    public class Enemy // 적 클래스
    {
        public int enemyX;
        public int enemyY;

        public Enemy()
        {
            //적 좌표 초기화
            enemyX = 77;
            enemyY = 12;
        }
        public void EnemyDraw() // 적 그리기
        {
            string enemy = "<-0->";
            Console.SetCursorPosition(enemyX, enemyY);//좌표설정
            Console.Write(enemy);//출력
        }
        public void EnemyMove()
        {
            Random rand = new Random(); //랜덤
            enemyX--; //왼쪽으로 움직임

            if(enemyX<2)
            {
                enemyX = 77;
                enemyY = rand.Next(2, 22);
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            // 플레이어 생성
            Player player = new Player();
            Enemy enemy = new Enemy();

            //유니티처럼 속도 프레임 속도
            int dwTime = Environment.TickCount; // 1/1000초가 흐른다.
            while (true) // 무한 반복
            {
                //Console.WriteLine(dwTime);
                //0.05초 지연
                if (dwTime + 10 < Environment.TickCount)
                {
                    //현재 시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    //플레이어
                    player.GameMain();
                    //총알
                    player.BulletDraw();

                    enemy.EnemyMove(); // 적 이동
                    enemy.EnemyDraw(); // 적 그리기
                    //충돌처리
                    player.ClashEnemyAndBullet(enemy);

                }

            }
        }
    }
}
