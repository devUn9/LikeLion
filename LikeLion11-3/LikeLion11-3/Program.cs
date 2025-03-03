using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion11_3
{
    class Program
    {

        static void Main(string[] args)
        {
            //두 수를 더하는 함수를 만들어서 오류를 해결하세요.

            int result = Add(10, 20);
            Console.WriteLine($"10 + 20 = {result}");

            //반복문

            string[] fruits = { "사과", "바나나", "체리" };
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }


        }

        static int Add(int a, int b)
        {
            return a + b;
        }


    }
}
