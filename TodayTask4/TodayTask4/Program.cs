using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask4
{
    //class Warrior
    //{
    //    public string Name { get; set; }
    //    public int Score { get; set; }
    //    public int Strength { get; set; }
    //    //생성자
    //    public Warrior(string name, int score, int strength)
    //    {
    //        Name = name;
    //        Score = score;
    //        Strength = strength;
    //    }
    //}
    //class Knight : Warrior
    //{
    //    public Knight(string name, int score, int strength) : base(name, score, strength)
    //    {
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //Warrior warrior1 = new Warrior("전사", 10,50);
            //Console.WriteLine($"이름 : {warrior1.Name}, 점수 : {warrior1.Score}, 힘 : {warrior1.Strength}");

            //Knight knight1 = new Knight("기사", 20, 100);
            //Console.WriteLine($"이름 : {knight1.Name}, 점수 : {knight1.Score}, 힘 : {knight1.Strength}");


            //int iNum = 0; string sNum = null;
            //sNum = Console.ReadLine();
            //try
            //{
            //    iNum = int.Parse(sNum);
            //    Console.WriteLine(iNum);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("올바른 숫자를 입력하세요!");
            //}



            //List<string> fruits = new List<string>();
            //fruits.Add("사과");
            //fruits.Add("바나나");
            //fruits.Add("포도");

            //Queue<string> works = new Queue<string>();
            //works.Enqueue("첫 번째 작업");
            //works.Enqueue("두 번째 작업");
            //works.Enqueue("세 번째 작업");

            //Stack<int> numbers = new Stack<int>();
            //numbers.Push(10);
            //numbers.Push(20);
            //numbers.Push(30);

            ////출력
            //foreach(var fruit in fruits)
            //    Console.WriteLine(fruit);
            //foreach (var work in works)
            //    Console.WriteLine(work);
            //foreach (var number in numbers)
            //    Console.WriteLine(number);


            ////문자열처리
            //string str = Console.ReadLine(); // Hello, C# World!

            //str = str.ToUpper(); // 1. 대문자 변경
            //StringBuilder sb = new StringBuilder(str);  // 2. 단어 변경
            //sb.Replace("C#", "CSharp");

            //Console.WriteLine(sb); // 1,2 출력
            //Console.WriteLine(sb?.Length); // 3. null 아니면 문자열 길이 출력




            //LINQ 활용
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);
            var evenSum = numbers.Sum();
            Console.Write("짝수만 출력 : ");
            foreach (var num in evenNumbers)
                Console.Write(num+" ");
            Console.WriteLine("\n모든 숫자의 합 : " + evenSum);

        }
    }
}
