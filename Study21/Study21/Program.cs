using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study21
{
    class Person
    {
        private string name; // 내부 변수

        //값 설정하기 (Setter)
        public void SetName(string newName)
        {
            name = newName;
        }
        public string GetName()
        {
            return name;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //C#에서 get/set 방식의 함수와 프로퍼티 비교

            Person p = new Person();
            p.SetName("홍길동");
            Console.WriteLine($"이름 : {p.GetName()}");


        }
    }
}
