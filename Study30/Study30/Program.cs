using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study30
{
    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다");

        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Dog myDog = new Dog();
            //Animal myAnimal = myDog; // 업캐스팅(Dog -> animal);

            //myAnimal.Speak(); // 사용가능

            ////myAnimal.Bark();
            ////오류 업캐스팅 후 자식 클래스의 메서드는 접근 불가
            ////----

            Animal myAnimal = new Dog();
            //Dog myDog = (Dog)myAnimal; // 다운캐스팅 (명시적 변환)

            Dog myDog = myAnimal as Dog;
            if(myDog != null)
            {
                myDog.Bark();
            }
            else
            {
                Console.WriteLine("변환 실패");
            }



            //Animal myAnimal2 = new Animal();
            //// Dog myDog = (Dog)myAnimal2; // 부모 메모리만 사용중이라 불가능

            if (myAnimal is Dog myDog2)
            {
                myDog2.Bark();
            }
            else
            {
                Console.WriteLine("변환할 수 없습니다.");
            }

        }
    }
}
