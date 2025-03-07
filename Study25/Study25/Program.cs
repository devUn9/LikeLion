using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study25
{
    class Program
    {
        class Cup<T>
        {
            public T Content { get; set; }
        }



        //public interface IEnumerator
        //{
        //    bool MoveNext(); // 다음 요소로 이동 (이동할 요소가 있으면 true 반환)
        //    object Current { get; } // 현재 요소 반환
        //    void Reset(); // 처음 위치로 리셋

        //}
        class SimpleCollection : IEnumerable<int>
        {
            private int[] data = { 1, 2, 3, 4, 5 };
            public IEnumerator<int> GetEnumerator()
            {
                foreach (var item in data)
                {
                    yield return item;
                }
            }
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
        



        static void Main(string[] args)
        {



            //Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            //Cup<int> cupOfInt = new Cup<int> { Content = 42 };
            //Console.WriteLine($"cupOfString : {cupOfString.Content}");
            //Console.WriteLine($"cupOfInt : {cupOfInt.Content}");



            //Stack<int> stack = new Stack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}



            //List<string> names = new List<String> { "Alice", "Bob", "Charlie" };
            //names.Add("Dave");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}



            //ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };

            //IEnumerator enumerator = list.GetEnumerator(); //열거자 가져오기


            //while (enumerator.MoveNext()) //다음 요소가 있는지 확인
            //{
            //    Console.WriteLine(enumerator.Current);//현재 요소 출력
            //}


            //var collection = new SimpleCollection();

            //foreach (var i in collection)
            //{
            //    Console.WriteLine(i);
            //}

            //Dictionary<string, int> ages = new Dictionary<string, int>();
            //ages["금도끼"] = 10;
            //ages["은도끼"] = 5;
            //ages["돌도끼"] = 1;

            //foreach(var pair in ages)
            //{
            //    Console.WriteLine($"{pair.Key} : {pair.Value}");
            //}



            ////null값
            //// 참조형식은 null을 가질 수 있으며,
            //// 값 형식은 기본적으로 null을 가질 수 없습니다.
            //string str = null;
            //if (str ==null)
            //{
            //    Console.WriteLine("str is null");
            //}
            //int? nullableInt = null;
            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            //nullableInt = 10;
            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");




            ////null 값을 다루는 연산자 소개하기 ??, ?. 연산자
            //// ?? 연산자를 사용해 null인경우 대체값을 제공
            //string str = null;
            //Console.WriteLine(str ?? "DeFaultValue");
            ////if (str == null) Console.WriteLine("DefaultValue");


            //// ?.은 null 안전 접근을 한다

            //str = "Hello";
            //Console.WriteLine(str?.Length); // null이 아니므로 길이 출력

            ////if (str != null) Console.WriteLine(str.Length);



            ////LINQ는 확장 메서드 형태로 제공된다.
            ////LINQ (Language Integrated Query)를 사용해 컬렉션을 쿼리할 수 있습니다.
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //var evenNumbers = numbers.Where(n => n % 2 == 0);
            //foreach (var num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}



        }
    }
}
