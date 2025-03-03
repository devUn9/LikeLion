using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study17
{
    class Program
    {
        // C# 구조체
        // 클래스와 비슷하지만 값 타입이며 가볍고 빠름
        // 주로 간단한 데이터 묶음을 만들 때 사용

        struct Point
        {
            //public 어디서든 사용가능하게 권한
            //private 나만 사용하려고 하는 키워드

            public int X;
            public int Y;

            //생성자 정의 처음 생성할 때 동작하는 함수
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public void Print()
            {
                Console.WriteLine($"좌표 : {X}, {Y}");
            }
        }

        //strutc Point는 X, Y 좌표 값을 저장하는 구조체
        // 구조체는 클래스와 다르게 new 없이 사용 가능

        //struct에도 생성자 사용 가능( 매개변수를 통한 초기화 가능)
        //모든 필드를 반드시 초기화해야함 (클래스와다름)

        static void Main(string[] args)
        {
            Point p;
            p.X = 10;
            p.Y = 20;

            p.Print();




            Point p1 = new Point(5, 15);
            p1.Print();

        }
    }
}
