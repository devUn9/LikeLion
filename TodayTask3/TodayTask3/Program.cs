using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask3
{
    class Program
    {
        static void Main(string[] args)
        {

            ////배열 문제 1.
            ////크기가 5인 정수 배열을 만들고
            ////{10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.

            //int[] iArray = new int[] { 10, 20, 30, 40, 50 };
            ////for (int i = 0; i < 5; i++)
            ////    Console.Write(iArray[i] + " ");
            //foreach (int arr in iArray)
            //    Console.Write(arr + " ");



            ////배열 문제 2.
            ////사용자가 5개의 점수를 입력하면 배열에 저장하고
            ////모든 수의 합을 출력

            //Console.Write("숫자 입력 : ");
            ////문자열 배열 score에 저장, 스페이스바로 분리해서 저장
            //string[] score = Console.ReadLine().Split(' ');
            //int sum = 0;

            ////정수형 배열 크기 5로 초기화
            //int[] iScore = new int[5];

            ////for문을 돌며 배열에서 배열 이동, 총합 계산
            //for (int i = 0; i < score.Length; i++)
            //{
            //    iScore[i] = int.Parse(score[i]);
            //    sum += iScore[i];
            //}
            //Console.WriteLine($"총 합 : {sum}");

            ////배열 문제 3.
            ////정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력

            //int[] iArray2 = new int[] { 3, 8, 15, 6, 2 };
            //int iMax = iArray2[0];
            //for (int i = 1; i < iArray2.Length; i++)
            //{
            //    if (iArray2[i] > iMax)
            //        iMax = iArray2[i];

            //}
            //Console.WriteLine($"최대값 : {iMax}");

            ////반복문 문제 1.
            ////1부터 10까지 출력 (for문)
            //for (int i = 0; i < 10; i++)
            //    Console.Write((i + 1) + " ");


            //// 반복문 문제 2.
            //// while문 사용하여 1부터 10까지 짝수만 출력
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0) Console.Write(i + " ");
            //    i++;
            //}

            //// 반복문 문제3.
            //// foreach문 사용하여 배열 {1,2,3,4,5} 요소 출력
            //int[] iArray = new int[] { 1, 2, 3, 4, 5 };
            //foreach (int arr in iArray)
            //    Console.Write(arr + " ");


            //// 함수 문제 1.
            //// 두개의 정수를 입력받아 합을 반환하는 함수 작성
            //int num1, num2;
            //num1 = int.Parse(Console.ReadLine());
            //num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{num1}과 {num2}의 합 : { Add(num1, num2)}");

            //// 함수 문제 2.
            //// 문자열을 입력받아 길이를 반환하는 함수 작성

            //Console.Write("문자열 입력: ");
            //string str = Console.ReadLine();

            //Console.WriteLine("문자열 길이: " + GetLength(str));

            // 함수 문제 3.
            // 세 개의 정수를 입력받아 가장 큰 값을 반환하는 함수 작성

            string[] numbers = Console.ReadLine().Split();
            int[] iNumbers = new int[3] ;
            for (int i = 0; i < numbers.Length; i++)
            {
                iNumbers[i] = int.Parse(numbers[i]);
            }

            Console.WriteLine($"가장 큰 수 : {GetMaxNumber(iNumbers[0], iNumbers[1], iNumbers[2])}");
        }
        static int GetMaxNumber(int a, int b, int c)
        {

            if ((a > b) && (a > c))
                return a;
            else if ((b > a) && (b > c))
                return b;
            else
                return c;

            //return Math.Max(a, Math.Max(b, c));
        }
        

        static int GetLength(string a)
        {
            return a.Length;
        }

        static int Add (int a, int b)
        {
            return a + b;
        } 
        

    }
}
