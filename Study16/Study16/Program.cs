using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study16
{
    class Program
    {
        //열거형
        //Enumeration enum
        //숫자 값에 이름을 부여하는 자료형
        // 가독성을 높이고, 의미있는 값으로 표현 가능
        // 기본적으로 첫 번째 값은 0부터 시작하며 1씩 증가
        // 기본적인 enum 사용법

        enum DayOfWeek
        {
            Sunday, // 0
            Monday, // 1
            Tuesday, // 2
            Wednesday, // 3
            Thursday,
            Friday,
            Saturday
        }
        
        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unaauthorized = 401,
            NotFound = 404
        }

        static void Main(string[] args)
        {

            //Math 클래스 사용
            //수학적 계산
            Console.WriteLine($"PI : {Math.PI}");
            Console.WriteLine($"루트 25 : {Math.Sqrt(25)}");
            Console.WriteLine($"2^3 : {Math.Pow(2, 3)}");
            Console.WriteLine($"반올림 : {Math.Round(3.75)}");

            DayOfWeek today = DayOfWeek.Wednesday;

            // 숫자를 직접 사용하지 않고, 의미 있는 이름으로 관리 가능

            Console.WriteLine(today);
            Console.WriteLine((int)today);

            StatusCode status = StatusCode.NotFound;
            Console.WriteLine(status);
            Console.WriteLine((int)status);

        }





        
    }
}
