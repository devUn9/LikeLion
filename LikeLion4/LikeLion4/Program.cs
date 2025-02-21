using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion4
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자열
            string greeting; // 문자열 변수 선언
            greeting = "Hello, World!"; // 변수에 값을 저장

            //변수의 값을 사용
            Console.WriteLine(greeting); // 출력 : Hello, World;

            Console.WriteLine("===============");

            //변수 선언과 초기화를 한번에 수행
            int score = 100; // 정수형 변수 선언과 동시에 100으로 초기화
            double temperature = 36.5; // 실수형 변수 선언과 초기화
            string city = "Seoul"; // 문자열 변수 선언과 초기화

            //변수 출력
            Console.WriteLine(score);       //출력 100
            Console.WriteLine(temperature); //출력 36.5
            Console.WriteLine(city);        //출력 Seoul

            Console.WriteLine("===============");

            int x = 10, y = 20, z = 30; //정수형 변수 x,y,z를 선언하고 초기화

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //Console.WriteLine($"{x}\n{y}\n{z}");

            Console.WriteLine("===============");

            const double Pi = 3.14159;  //실수형 상수 PI 선언 및 초기화
            const int MaxScore= 100; // 정수형 상수 선언 및 초기화

            //출력
            Console.WriteLine("Pi : " + Pi);
            Console.WriteLine("MaxScore :" + MaxScore);

            Console.WriteLine("===============");

            int att, maxhp, property1, property2, property3, property4, property5, property6;
            att = 16766;
            maxhp = 78103;
            property1 = 36;
            property2 = 1017;
            property3 = 41;
            property4 = 611;
            property5 = 22;
            property6 = 39;

            Console.WriteLine($"공격력\t{att,20}");
            Console.WriteLine($"최대 생명력{maxhp,17}");

            Console.WriteLine();
            Console.WriteLine($"치명\t{property1,20}");
            Console.WriteLine($"특화\t{property2,20}");
            Console.WriteLine($"제압\t{property3,20}");
            Console.WriteLine($"신속\t{property4,20}");
            Console.WriteLine($"인내\t{property5,20}");
            Console.WriteLine($"숙련\t{property6,20}");
        }
    }
}
