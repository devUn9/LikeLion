using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 두 값을 비교하여 관계를 평가한다.
            // == 같다 != 같지않다 > 크다 < 작다

            int x = 5, y = 10;
            Console.WriteLine(x == y); // false
            Console.WriteLine(x != y);  // true
            Console.WriteLine(x < y); // true
            Console.WriteLine(x > y);   // f
            Console.WriteLine(x <= y);  // t
            Console.WriteLine(x >= y);  // f


            //논리 연산자
            bool a = true;
            bool b = false;

            Console.WriteLine(a && b);  // false
            //AND 1 : 1     t
            //AND 1 : 0     f
            //AND 0 : 1     f
            //AND 0 : 0     f

            Console.WriteLine(a || b);  // true
            //OR 1 : 1      t
            //OR 1 : 0      t
            //OR 0 : 1      t
            //OR 0 : 0      f

            b = a;
            Console.WriteLine(b); // true

            b = !a; // true의 not을 b에 할당
            Console.WriteLine(b); // false


            //비트 연산자
            int x = 5; // 0101
            int y = 3; // 0011

            Console.WriteLine(x & y); // AND : 1 (0001)
            Console.WriteLine(x | y); // OR : 7 (0111)
            Console.WriteLine(x ^ y); // XOR : 6 (0110)
            // XOR은 같은것끼리 더하면 0 다르면 1
            Console.WriteLine(~x);      // NOT : -6


            //시프트 연산
            int value = 4; // 0100
            Console.WriteLine(value << 1); // 왼쪽이동 : 8 (1000)
            Console.WriteLine(value >> 1); // 왼쪽이동 : 2 (0010)



            삼항 연산자(비교) ? a: b
            int a = 10, b = 20;

            int max;
            max = (a > b) ? a : b;
            Console.WriteLine(max); // (false) ? true: false 이므로 false 출력

            // (비교) ? 참 : 거짓 ;
            // 비교 값에 따라 값 출력

            int key = 1;
            string str;
            str = (key == 1) ? "문이 열렸습니다." : "문을 열지 못했습니다.";

            Console.WriteLine(str);


            int result = 10 + 2 * 5;
            Console.WriteLine(result); // 10 + 10;

            int adjustedResult = (10 + 2) * 5; // 괄호 우선순위 먼저 계산

            Console.WriteLine(adjustedResult); // 12 * 5



            if 조건문

            int score = 85;
            if (score >= 90) // if(false)
            {
                Console.WriteLine("A 학점");
            }
            else
            {
                Console.WriteLine("B 학점");
            }



            string GameID = "멋사검존";

            //if (string.Compare(GameID,"멋사검존")== 0) 안전한 방법
            if (GameID == "멋사검존")
            {
                Console.WriteLine("아이디가 일치합니다.");
            }
            else
            {
                Console.WriteLine("아이디가 일치하지 않습니다.");
            }

            int score = 75;

            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else
            {
                Console.WriteLine("D 학점");
            }


            //가지고 있는 소지금을 입력하세요
            //0~100 무한의대검
            //101~200 카타나
            //201~300 진은검
            //301~400 집판검
            //401~500 엑스칼리버
            //501~600 유령검

            //Console.Write("가지고 있는 소지금을 입력하세요. : ");
            //int gold = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //int lastgold = gold;
            //int att = 100;
            //string weapon = "";

            //if (gold > 600)
            //{
            //    weapon = "전설의검";
            //    att += 7;
            //    gold -= 600;

            //    Console.WriteLine($"600골드를 사용하여 {weapon}을 구매했습니다.\n");

            //    Console.WriteLine("캐릭터 : 멋사검존");
            //    Console.WriteLine($"무기 : {weapon}");
            //    Console.WriteLine($"공격력 : {att}(+7)");

            //    Console.WriteLine($"남은 골드 : {gold}");

            //}
            //else if (gold > 500)
            //{
            //    weapon = "유령검";
            //    att += 6;
            //    gold -= 500;

            //    Console.WriteLine($"500골드를 사용하여 {weapon}을 구매했습니다.\n");

            //    Console.WriteLine("캐릭터 : 멋사검존");
            //    Console.WriteLine($"무기 : {weapon}");
            //    Console.WriteLine($"공격력 : {att}(+6)");

            //    Console.WriteLine($"남은 골드 : {gold}");
            //}
            //else if (gold > 400)
            //{
            //    weapon = "엑스칼리버";
            //    att += 5;
            //    gold -= 400;

            //    Console.WriteLine($"400골드를 사용하여 {weapon}을 구매했습니다.\n");

            //    Console.WriteLine("캐릭터 : 멋사검존");
            //    Console.WriteLine($"무기 : {weapon}");
            //    Console.WriteLine($"공격력 : {att}(+5)");

            //    Console.WriteLine($"남은 골드 : {gold}");
            //}
            //else if (gold > 300)
            //{
            //    weapon = "유령검";
            //    att += 4;
            //    gold -= 300;

            //    Console.WriteLine($"300골드를 사용하여 {weapon}을 구매했습니다.\n");

            //    Console.WriteLine("캐릭터 : 멋사검존");
            //    Console.WriteLine($"무기 : {weapon}");
            //    Console.WriteLine($"공격력 : {att}(+4)");

            //    Console.WriteLine($"남은 골드 : {gold}");
            //}
            //else if (gold > 200)
            //{
            //    weapon = "유령검";
            //    att += 3;
            //    gold -= 200;

            //    Console.WriteLine($"200골드를 사용하여 {weapon}을 구매했습니다.\n");

            //    Console.WriteLine("캐릭터 : 멋사검존");
            //    Console.WriteLine($"무기 : {weapon}");
            //    Console.WriteLine($"공격력 : {att}(+3)");

            //    Console.WriteLine($"남은 골드 : {gold}");
            //}
            //else if (gold > 100)
            //{
            //    weapon = "유령검";
            //    att += 2;
            //    gold -= 100;

            //    Console.WriteLine($"100골드를 사용하여 {weapon}을 구매했습니다.\n");

            //    Console.WriteLine("캐릭터 : 멋사검존");
            //    Console.WriteLine($"무기 : {weapon}");
            //    Console.WriteLine($"공격력 : {att}(+2)");

            //    Console.WriteLine($"남은 골드 : {gold}");
            //}
            //else
            //{
            //    weapon = "무한의대검";
            //    att += 1;
            //    gold -= 0;

            //    Console.WriteLine($"0골드를 사용하여 {weapon}을 구매했습니다.\n");

            //    Console.WriteLine("캐릭터 : 멋사검존");
            //    Console.WriteLine($"무기 : {weapon}");
            //    Console.WriteLine($"공격력 : {att}(+1)");

            //    Console.WriteLine($"남은 골드 : {gold}");
            //}


            //gpt 도움
            Console.Write("가지고 있는 소지금을 입력하세요. : ");
            int gold = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int lastgold = gold;
            int att = 100;
            string weapon = "";

            if (gold > 600)
            {
                weapon = "전설의검";
                att += 7;
                gold -= 600;
            }
            else if (gold > 500)
            {
                weapon = "유령검";
                att += 6;
                gold -= 500;
            }
            else if (gold > 400)
            {
                weapon = "엑스칼리버";
                att += 5;
                gold -= 400;
            }
            else if (gold > 300)
            {
                weapon = "집판검";
                att += 4;
                gold -= 300;
            }
            else if (gold > 200)
            {
                weapon = "진은검";
                att += 3;
                gold -= 200;
            }
            else if (gold > 100)
            {
                weapon = "카타나";
                att += 2;
                gold -= 100;
            }
            else
            {
                weapon = "무한의대검";
                att += 1;
            }

            Console.WriteLine("=========================================");
            Console.WriteLine($"|  {weapon}을(를) 획득했습니다!   ");
            Console.WriteLine("=========================================");
            Console.WriteLine("|  캐릭터 : 멋사검존");
            Console.WriteLine($"|  무기 : {weapon}");
            Console.WriteLine($"|  공격력 : {att} (+{att - 100})");
            Console.WriteLine($"|  사용 골드 : {lastgold - gold}");
            Console.WriteLine($"|  남은 골드 : {gold}");
            Console.WriteLine("=========================================");
        }
    }
}
