using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study27
{
    //부모 클래스 
    class Animal
    {
        public string Name { get; set; }
        
        public void Eat()
        {
            Console.WriteLine($"{Name}이(가) 음식을 먹고 있습니다.");
        }
    }
    //자식 클래스(파생 클래스)
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.Name = "멍멍이";
            dog1.Eat();
            dog1.Bark();
        }
    }
}
