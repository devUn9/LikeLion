using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion7
{
    class Program
    {
        static void Main(string[] args)
        {

            ////단항 연산자 예
            //int number = 5;
            //bool flag = true;

            //Console.WriteLine(+number); // 5
            //Console.WriteLine(+number); // -5

            //Console.WriteLine(!flag); // 논리 부정 : false

            //// ~ 비트 반전 NOT 연산자
            //// 1010 >> 0101 즉, 10이 5가 된다 
            //int num = 10;
            ////Console.WriteLine(~num);
            //int result = ~num;

            //Console.WriteLine("원래값:" + num);
            //Console.WriteLine("~연산자 적용 후 : " + result);


            //캐스팅 연산자



            //double pi = 3.14;
            //int integerPi = (int)pi; // 실수형 -> 정수형

            //Console.WriteLine(integerPi); //3

            //int iKor = 90;
            //int iEng = 75;
            //int iMath = 58;
            //int sum = 0;
            //float average = 0.0f;

            //sum = iKor + iEng + iMath;

            //average = (float)sum / 3.0f;
            //Console.WriteLine(sum);
            //Console.WriteLine("평균 : " + average);



            //int a = 10, b = 3;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);


            ////문자열 연결 연산자

            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + " " + lastName); // 출력



            //// 할당 연산자
            //int a = 10;
            //a += 5; // a = a + 5;
            //Console.WriteLine(a);
            //a -= 5; // a = a - 5;
            //Console.WriteLine(a);
            //a *= 5; // a = a * 5;
            //Console.WriteLine(a);
            //a /= 5; // a = a / 5;
            //Console.WriteLine(a);
            //a %= 5; // a = a % 5;
            //Console.WriteLine(a);


            ////문제 1.학점 평균 계산 프로그램
            //int iKor = 0, iEng = 0, iMath = 0;

            //Console.WriteLine("문제1.학점 평균 계산 프로그램");
            //Console.WriteLine("국어 점수를 입력하세요.");
            //iKor = int.Parse(Console.ReadLine());
            //Console.WriteLine("영어 점수를 입력하세요.");
            //iEng = int.Parse(Console.ReadLine());
            //Console.WriteLine("수학 점수를 입력하세요.");
            //iMath = int.Parse(Console.ReadLine());

            //int sum = iKor + iEng + iMath;
            //float average = (float)sum / 3;

            //Console.WriteLine($"총점 : {sum}");
            //Console.WriteLine($"평균 : {average.ToString("F2")}");

            //Console.WriteLine("\n========================");

            ////문제 2. 비트 반전(~) 연산자 활용 프로그램

            //Console.WriteLine("문제2.비트 반전(~) 연산자 활용 프로그램");

            //int num = 0;

            //Console.WriteLine("정수를 입력하세요.");
            //num = int.Parse(Console.ReadLine());
            //int notnum = ~num;

            //Console.WriteLine($"비트 반전 값 : {notnum}");


            //증감 연산자

            int b = 3;
            //전위 ++b
            ++b;
            Console.WriteLine("b의 값은 : " + b);
            ++b;
            Console.WriteLine("b의 값은 : " + b);

            //후위 b++
            int c = 3;
            Console.WriteLine("c의 값은 : " + (c++));
            
            Console.WriteLine("c의 값은 : " + c);

        }
    }
}
