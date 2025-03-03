using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study21_3
{
    class Person
    {
        private int count = 100;
        public string Name { get; set; } // 프로퍼티 자동 구현
        public int Count
        {
            get { return count; } // get만 가능, 읽기만
        }
        public float Balance { get; private set; } // 외부 변경 불가
        public void AddBal()
        {
            Balance += 200;
        }
    }

    //마린 클래스 프로퍼티 이용해서 이름과 미네랄 마린,50
    class Marine
    {
        public string Name { get; set; } = "마린";
        public int Mineral { get; set; } = 100;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "홍길동";
            Console.WriteLine("이름 : " + p.Name);
            //p.Count = 1; // 값 설정 불가능
            Console.WriteLine("카운트 : " + p.Count); // get
            p.AddBal();
            Console.WriteLine($"이름: {p.Name} Count : {p.Count} Balance : {p.Balance}");

            Marine marine = new Marine();
            //marine.Name = "불꽃테란";
            Console.WriteLine($"이름 : {marine.Name} 미네랄: {marine.Mineral}");
        }
    }
}
