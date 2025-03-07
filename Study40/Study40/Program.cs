using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study40
{
    class Parent
    {
        public Parent(string message)
        {
            Console.WriteLine("부모생성자" + message); // 2
        }
    }
    class Child : Parent
    { 
        public Child():base("하하하하성공") // 부모 생성자 호출 1
        {
            Console.WriteLine("자식생성자 호출"); // 3
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child(); // 객체 생성
        }
    }
}
