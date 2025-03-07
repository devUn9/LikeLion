 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyy
{
    static class Utility
    {
        static Utility()  // 정적 생성자
        {
            Console.WriteLine("static 클래스 생성자 실행!");
        }

        public static void DoSomething()
        {
            Console.WriteLine("static 메서드 실행!");
        }
    }
    //class Player
    //{
    //    protected string Name;   //protected 부모랑 자식 상속관계에서만 사용하고싶을때

    //    public Player()
    //    {
    //        Name = "플레이어";
    //        Console.WriteLine("부모 생성자입니다.");
    //    }

    //    public void Show()
    //    {
    //        Console.WriteLine(Name);
    //    }
    //}

    //class Wizard : Player
    //{
    //    public Wizard()
    //    {
    //        Name = "마법사";
    //        Console.WriteLine("자식 생성자입니다.");
    //    }
    //}




    class Program
    {
        static void Main(string[] args)
        {
            Utility.DoSomething();
            Utility.DoSomething();
            Utility.DoSomething();
            



        }
    }
}
