using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study20
{
    class Person
    {
        public string Name;
        public int Age;
        //public string name = "홍길동";


        //기본생성자 
        //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
        //클래스와 같은이름가지며, 반환형이 없다 (void도 사용하지않음)
        //객체를 만들때 필요한 초기값을 설정할대 사용많이한다.

        public Person(String name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("기본 생성자가 실행됨");
        }


        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("철수",25); // 객체 생성 instance
            p1.ShowInfo();

            Person p2 = new Person("영희", 30);
            p2.ShowInfo();
        }
    }
}
