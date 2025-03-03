using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study18_3
{

    //구조체를 사용해서
    // 학생 3명의 이름 성적을 받고
    // 국어 영어 수학 출력
    //홍길동 100 80 70
    //홍길란 90 10 20
    //홍길순 25 55 70
    

    class Program
    {
        struct Student
        {
            public string Name;
            public int iKor;
            public int iEng;
            public int iMath;

            //학생 정보를 출력하는 함수
            public void Print()
            {
                Console.WriteLine($"{Name,-3} {iKor,5}{iEng,7}{iMath,8}");
            }
        }


        static void Main(string[] args)
        {
            //학생 배열 선언
            Student[] students = new Student[3];

            for(int i =0; i<students.Length;i++)
            {
                Console.WriteLine("학생 성적을 입력하세요.");
                Console.Write("학생 이름 : ");
                students[i].Name = Console.ReadLine();
                Console.Write("국어 : ");
                students[i].iKor = int.Parse(Console.ReadLine());
                Console.Write("영어 : ");
                students[i].iEng = int.Parse(Console.ReadLine());
                Console.Write("수학 : ");
                students[i].iMath = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("이름    국어    영어    수학");
            foreach (Student std in students)
            {
                
                std.Print();
            }
            

            

        }
    }
}
