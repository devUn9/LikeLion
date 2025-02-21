using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion5
{
    class Program
    {
        static void Main(string[] args)
        {
            ////숫자 데이터 형식 : 정수와 실수를 따룰 때 사용하는 다양한 타입
            //int integerNum = 10; //정수 데이터
            //float floatNum = 3.14f; //단정밀도 실수
            //double doubleNum = 3.14159; //배정밀도 실수

            //Console.WriteLine(integerNum);
            //Console.WriteLine(floatNum);
            //Console.WriteLine(doubleNum);

            //정수 데이터형식 : 소수점이 없는 숫자릂 표현
            int intValue = -100; //4바이트 크기의 정수
            long longValue = 123456790L;

            Console.WriteLine(intValue);
            Console.WriteLine(longValue);

            Console.WriteLine("========================");

            sbyte signedByte = -50; //1byte
            short signedShort = -32000; //2byte
            int signedInt = -2000000; //4byte

            Console.WriteLine(signedByte);
            Console.WriteLine(signedShort);
            Console.WriteLine(signedInt);

            Console.WriteLine("========================");

            //부호 없는 정수 데이터 형식
            byte unsignedByte = 255; // 1byte
            ushort unsignedShort = 65000;
            uint unsignedInt = 400000000;

            Console.WriteLine(unsignedByte);
            Console.WriteLine(unsignedShort);
            Console.WriteLine(unsignedInt);

            Console.WriteLine("========================");

            //실수형 데이터 형식 : 소수점을 포함한 숫자를 표현
            float singlePrecision = 3.14f; //단정밀도 실수 4바이트
            double doublePrecision = 3.1415926535; //배정밀도 실수 (8바이트)
            decimal highPrecision = 3.14159265358979323846m; // 고정밀도 (16바이트)

            Console.WriteLine(singlePrecision);
            Console.WriteLine(doublePrecision);
            Console.WriteLine(highPrecision);


            Console.WriteLine("========================");

            //접미사 사용 : 숫자의 데이터 형식을 명시

            int integerValue = 100;
            long longValue2 = 100L;
            float floatValue = 3.14f;
            double doubleValue = 3.14;
            decimal decimalValue = 3.14m;

            Console.WriteLine(integerValue);
            Console.WriteLine(longValue2);
            Console.WriteLine(floatValue);
            Console.WriteLine(doubleValue);
            Console.WriteLine(decimalValue);

            Console.WriteLine("========================");

            //char 형식 : 단일 문자를 표현
            char letter = 'A'; //문자 'A' 저장
            char symbol = '#'; //특수 기호 저장
            char number = '9'; //숫자 형태의 문자 저장(문자 '9', 숫자 9 아님)

            Console.WriteLine(letter);
            Console.WriteLine(symbol);
            Console.WriteLine(number);

            //string 형식 : 여러 문자를 저장
            string greeting = "Hello World";  //문자열 저장
            string name = "Alice"; //이름 저장

            Console.WriteLine(greeting); //출력 : Hello,World
            Console.WriteLine(name); //출력 : Alice

            //Hello World Alice
            Console.Write(greeting); Console.Write(name);
            Console.Write(greeting + name);
            //Console.WriteLine($"{greeting} {name}");


            //bool 형식
            //참 true 1
            //거짓 false 0
            bool isRunning = true; //프로그램 실행 상태
            bool isFinished = false;

            Console.WriteLine(isRunning);
            Console.WriteLine(isFinished);

            Console.WriteLine("========================");

            //상수 const 키워드로 선언
            const double Pi = 3.14159;  //실수형 상수 PI 선언 및 초기화
            const int MaxScore = 100; // 정수형 상수 선언 및 초기화

            Console.WriteLine("Pi : " + Pi);
            Console.WriteLine("MaxScore :" + MaxScore);

            //Pi = 3.14;

            //닷넷 표현
            System.Int32 number2 = 123; //int 닷넷형식
            System.String text = "Hello";
            System.Boolean flag = true;
            Console.WriteLine(number2);

            Console.WriteLine("========================");

            //int 래퍼 형식의 메서드 활용
            int number3 = 123;
            string numberAsString = number3.ToString(); // 정수를 문자열로 변환

            //bool 래퍼형식
            bool flag2 = true;
            string flagAsString = flag.ToString(); // 논리값을 문자열로 변환

            Console.WriteLine(numberAsString);
            Console.WriteLine(flagAsString);

        }
    }
}
