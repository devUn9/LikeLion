using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPGTEST
{
    public class INFO
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }
        public INFO()
        {
            Name = "초보자";  // 초기값 설정
            Health = 100;
            Power = 10;
        }
    }
    public class Player
    {
        // Player has INFO, 포함 관계
        public INFO PlayerInfo;
        // 플레이어가 입는 데미지 계산 함수
        public int PlayerTakeDamage(int power)
        {
            return (PlayerInfo.Health -= power);
        }
        public INFO GetInfo() { return PlayerInfo; }


        public void SetHealth(int Health) { PlayerInfo.Health = Health; }
        public int SelectJob()
        {
            PlayerInfo = new INFO();
            Console.WriteLine("직업을 선택하세요. (1.기사 2.마법사 3.도둑)");
            int ijob = 0;
            while (true)
            {
                try
                {
                    ijob = int.Parse(Console.ReadLine());
                    if (ijob < 1 || ijob > 3)
                    {
                        Console.WriteLine("1~3 사이의 숫자를 입력하세요.");

                        continue;
                    }
                    else return ijob;
                }
                catch
                {
                    Console.WriteLine("숫자를 입력하세요.");
                    continue;
                }
            }
        }
        public void PlayerJob(int i)
        {
            switch (i)
            {
                case 1:
                    PlayerInfo.Name = "기사";
                    PlayerInfo.Health = 100;
                    PlayerInfo.Power = 10;
                    break;
                case 2:
                    PlayerInfo.Name = "마법사";
                    PlayerInfo.Health = 90;
                    PlayerInfo.Power = 12;
                    break;
                case 3:
                    PlayerInfo.Name = "도둑";
                    PlayerInfo.Health = 80;
                    PlayerInfo.Power = 15;
                    break;
            }
        }

        public void Render()
        {
            Console.WriteLine("===================");
            Console.WriteLine($"직업 이름 : {PlayerInfo.Name}");
            Console.WriteLine($"체력 : {PlayerInfo.Health} \t 공격력 {PlayerInfo.Power}");

        }



    }
    public class Monster
    {
        public INFO MonsterInfo;
        public int MonsterTakeDamage(int power)
        {
            return (MonsterInfo.Health -= power);
        }
        public void Render()
        {
            Console.WriteLine("===============");
            Console.WriteLine($"몬스터이름 : {MonsterInfo.Name}");
            Console.WriteLine($"체력 : {MonsterInfo.Health} \t 공격력 : {MonsterInfo.Power}");

        }



        public void SetMonster(INFO tMonster)
        {
            MonsterInfo = tMonster;
        }
        public INFO GetMonster()
        {
            return MonsterInfo;
        }



    }

    public class Field
    {
        Player fieldplayer = null;
        Monster fieldmonster = null;

        public void SetPlayer(Player mainplayer)
        {
            fieldplayer = mainplayer;
        }
        public void Update()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                fieldplayer.Render();
                DrawMap();

                try
                {
                    iInput = int.Parse(Console.ReadLine());
                    if (iInput < 1 || iInput > 4)
                    {
                        Console.WriteLine("1~4 사이의 숫자를 입력하세요.");

                        continue;
                    }

                }
                catch
                {
                    Console.WriteLine("숫자를 입력하세요.");
                    continue;
                }
                if (iInput == 4)
                {
                    break;
                }
                else if (iInput <= 3)
                {
                    CreateMonster(iInput);
                    //싸운다
                    Fight();
                }
            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1.초보맵");
            Console.WriteLine("2.중수맵");
            Console.WriteLine("3.고수맵");
            Console.WriteLine("4.전단계");
            Console.WriteLine("=========");
            Console.Write("맵을 선택하세요 : ");
        }
        public void Fight()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear(); // 콘솔화면 지움
                fieldplayer.Render(); // 플레이어 정보
                fieldmonster.Render(); // 몬스터 정보 출력

                Console.WriteLine("1. 공격 2. 도망 : ");  

                try
                {
                    iInput = int.Parse(Console.ReadLine());
                }
                catch
                {

                }
   
                if (iInput == 1)
                {
                    //플레이어 데미지 주기 (몬스터 공격력 넣어서)
                    fieldplayer.PlayerTakeDamage(fieldmonster.GetMonster().Power);
                    fieldmonster.MonsterTakeDamage(fieldplayer.GetInfo().Power);

                    if (fieldplayer.GetInfo().Health <= 0) //플레이어 체력이 0 이하면
                    {
                        fieldplayer.SetHealth(100);
                        break;
                    }

                }
                if (iInput == 2 || fieldmonster.GetMonster().Health <= 0)
                {
                    fieldmonster = null;
                    break; //탈출
                }
            }
        }

        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster(); // 몬스터 생성
            INFO tMonster = new INFO(); // 몬스터 데이터 메모리 주기 객체 생성

            tMonster.Name = _strName; // 초보 몬스터, 중, 고
            tMonster.Health = _iHp; //체력
            tMonster.Power = _iAttack;

            pMonster.SetMonster(tMonster); // 생성된 데이터
        }

        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    //공장처럼 찍어내준다.
                    //디자인패턴의 팩토리 메서드 패턴
                    Create("초보몹", 30, 3, out fieldmonster);
                    break;

                case 2:
                    //공장처럼 찍어내준다.
                    //디자인패턴의 팩토리 메서드 패턴
                    Create("중수몹", 60, 6, out fieldmonster);
                    break;
                case 3:
                    //공장처럼 찍어내준다.
                    //디자인패턴의 팩토리 메서드 패턴
                    Create("고수몹", 90, 9, out fieldmonster);
                    break;

            }
        }

    }



    class MainGame
    {
        public Player mainplayer = null;
        public Field field = null;

        public void Initialize()
        {
            mainplayer = new Player();

            int job = mainplayer.SelectJob();
            mainplayer.PlayerJob(job);


        }
        public void Update()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                mainplayer.Render();

                Console.WriteLine("1.사냥터 2.종료 : ");
                try
                {
                    iInput = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("숫자만 입력하세요.");
                }
                if (iInput == 2)
                {
                    break;
                }
                else if (iInput == 1)
                {
                    //사냥터 구현
                    if (field == null)
                    {
                        field = new Field();
                        //필드로 갈때 플레이어 너ㅎ어주기
                        field.SetPlayer(mainplayer);
                    }
                    field.Update();
                }
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            MainGame mainGame = new MainGame();
            mainGame.Initialize();
            mainGame.Update();

        }
    }
}
