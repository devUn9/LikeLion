using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 문제1. 세 정수의 최대값 구하기
            //int num1, num2, num3 = 0;

            //Console.Write("첫번째 정수를 입력하세요 : ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("\n두번째 정수를 입력하세요 : ");
            //num2 = int.Parse(Console.ReadLine());

            //Console.Write("\n세번째 정수를 입력하세요 : ");
            //num3 = int.Parse(Console.ReadLine());

            //if ((num1 > num2) && (num1 > num3))
            //{
            //    Console.WriteLine($"\n최대값 : {num1}");
            //}
            //else if ((num2 > num1) && (num2 > num3))
            //{
            //    Console.WriteLine($"\n최대값 : {num2}");
            //}
            //else
            //{
            //    Console.WriteLine($"\n최대값 : {num3}");
            //}

            //문제 2. 점수에 따른 학점 평가
            //int score = default;
            //char grade = default;

            //Console.Write("점수를 입력하세요 : ");
            //score = int.Parse(Console.ReadLine());
            //if (score >= 90)
            //    grade = 'A';
            //else if (score >= 80)
            //    grade = 'B';
            //else if (score >= 70)
            //    grade = 'C';
            //else if (score >= 60)
            //    grade = 'D';
            //else
            //    grade = 'F';

            //Console.WriteLine($"{grade} 학점");

            //문제3. 간단한 사칙연산 계산기
            int number1, number2, result = default;

            string operator1 = default;

            Console.Write("첫번쨰 수를 입력하세요 : ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("두번쨰 수를 입력하세요 : ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("두 수를 계산할 연산자를 입력하세요 : ");
            operator1 = Console.ReadLine();

            if (operator1 == "+")
            {
                result = number1 + number2;
            }
            else if (operator1 == "-")
            {
                result = number1 - number2;
            }
            else if (operator1 == "*")
            {
                result = number1 * number2;
            }
            else if (operator1 == "/")
            {
                if (number2 == 0)
                {
                    Console.WriteLine("0으로 나눌 수 없습니다.");
                    return;
                }
                else
                {
                    result = number1 / number2;
                }
            }
            else
            {
                Console.WriteLine("연산자가 +,-,*,/ 중 하나인지 확인해주세요.");
                return;
            }
            Console.WriteLine($"결과 값: {result}");

        }
    }
}
