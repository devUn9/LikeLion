using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study20_2
{
    //마린 클래스를 만드세요.
    // 이름, 미네랄
    // 기본 생성자, 인자있는 생성자

    class Marine
    {
        public string Name;
        public int Mineral;

        public Marine()
        {
            Name = "마린";
            Mineral = 50;
        }



        public Marine(string name, int mineral)
        {
            Name = name;
            Mineral = mineral;
        }
        public void ShowMarine()
        {
            Console.WriteLine($"이름 : {Name}\n미네랄 : {Mineral}");
        }

    }

    class SCV
    {
        public string Name;
        public int Mineral;

        public SCV()
        {
            Name = "SCV";
            Mineral = 50;
        }
        public SCV(string name, int mineral)
        {
            Name = name;
            Mineral = mineral;
        }
        public void ShowSCV()
        {
            Console.WriteLine($"이름 : {Name}\n미네랄 : {Mineral}");
        }
    }
    class Barrack
    {
        public string Name; // 멤버 변수 (필드 선언)
        public int Mineral;

        public Barrack()
        {
            Name = "배럭"; // 필드 초기화
            Mineral = 150;
        }

        public Barrack(string name, int mineral)
        {
            this.Name = name;
            this.Mineral = mineral;
        }
        public void ShowBarrack()
        {
            Console.WriteLine($"이름 : {Name}\n미네랄 : {Mineral}");
        }
    }

    //미네랄 클래스를 만드시오
    // Mineral 1500 기본으로
    // 7개가 시작부터 있다
    // 클래스화 해본다.
    class Mineral
    {
        public int MineralCount;
        public Mineral()
        {
            MineralCount = 1500;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"현재 미네랄 개수 : {MineralCount}");
        }
    }
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int popul;

        public static void ShowInfo()
        {
            Console.WriteLine($"{mineral} {gas} {popul}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Marine m1 = new Marine();
            Marine m2 = new Marine("불꽃테란", 500);
            m1.ShowMarine();
            m2.ShowMarine();

            SCV s1 = new SCV();
            SCV s2 = new SCV("열받은SCV", 1000);
            s1.ShowSCV();
            s2.ShowSCV();

            Barrack b1 = new Barrack();
            b1.ShowBarrack();


            //클래스의 배열
            Mineral[] mineral = new Mineral[7];

            //각 배열에 new 객체화
            for (int i = 0; i < mineral.Length; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShowInfo();
            }

            Game.mineral = 50;
            Game.gas = 0;
            Game.popul = 4;
            Game.ShowInfo();

        }
    }
}
