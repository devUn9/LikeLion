using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study21_2
{
    class Person
    {
        //프로퍼티
        private string name; // 내부 변수
        public string Name // 프로퍼티
        {
            get { return name; } // Getter
            set { name = value; } // Setter
        }

        class Program
        {
            static void Main(string[] args)
            {
                Person p = new Person();

                p.Name = "홍길동";

                Console.WriteLine("이름 : " + p.Name);

            }
        }
    }
}

