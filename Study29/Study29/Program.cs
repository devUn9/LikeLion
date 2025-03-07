using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study29
{
    //public class로 안써도 같은 공간이라 쓸 수 있다

    class Animal
    {
        public string Name { get; set; }
        //virtual (가상 메서드), 자식클래스에서 재정의 가능
        public void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    class Dog : Animal
    {
        //부모 클래스의 메서드를 오버라이딩 (재정의)
        public void Speak()
        {
            Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.Name = "일반동물";
            myAnimal.Speak(); // 부모 클래스의 기본 메서드 실행
            
            
            //메서드 하이딩 예임
            Dog myDog = new Dog();
            myDog.Name = "바둑이";
            myDog.Speak(); //오버라이딩된 메서드 실행



            //오버라이딩 예
            //Animal myDog2 = new Dog();
            //myDog2.Name = "바둑이";
            //myDog2.Speak(); //오버라이딩된 메서드 실행
        }
    }
}
