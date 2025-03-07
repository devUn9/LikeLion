using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study33
{
    class Player
    {
        protected string Name; //protected 부모랑 자식 상속관계에서만 사용하고 싶을 때
        public Player()
        {
            Name = "플레이어";
            Console.WriteLine("부모 생성자입니다.");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }
    }
    class Wizard : Player
    {
        
        public Wizard()
        {
        Name = "마법사";
            Console.WriteLine("자식생성자입니다.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Player p = new Player();
            //p.Show();

            Wizard w = new Wizard();
            w.Show();

            //생성자는 객체가 생성될때 실행되고, 자식 클래스 객체 생성될때는 부모 클래스 객체가 먼저 생성되니까 자식 클래스의 메서드 실행 시 부모 클래스 생성자 >  자식 클래스 생성자 > 자식 클래스 메서드 순으로 실행
        }
    }
}
