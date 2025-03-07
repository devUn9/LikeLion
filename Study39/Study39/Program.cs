using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study39
{
    abstract class Animal
    {
        //추상 메서드 (구현 x, 상속받은 클래스가 구현)
        public abstract void MakeSound();

        //일반 메서드 (공통 기능 제공)
          public void Sleep()
        {
            Console.WriteLine("동물이 잠을 잡니다.");
        }
    }
    //추상 클래스를 상속받아 구체적인 클래스 구현
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("멍멍!");
        }
    }
    
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("냐옹~");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            myDog.MakeSound();
            myDog.Sleep();

            Animal myCat = new Cat();
            myCat.MakeSound();
            myCat.Sleep();

        }
    }
}
