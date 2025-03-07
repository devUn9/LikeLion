using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam
{
    //인터페이스를
    interface IAnimal
    {
        void Speak();
    }
    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("멍멍");
        }
    }
    class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("야옹");
        }
    }

    //인터페이스를 활용한 공통메서드
    class AnimalTrainer
    {
        public void Train(IAnimal animal)
        {
            Console.Write("동물이 소리를 냅니다.");
            animal.Speak();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AnimalTrainer trainer = new AnimalTrainer();

            IAnimal myDog = new Dog();
            IAnimal myCat = new Cat();

            trainer.Train(myDog);
            trainer.Train(myCat);
        }
    }
}
