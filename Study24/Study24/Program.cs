using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study24
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Stack
            //Stack stack = new Stack();
            //{
            //    stack.Push(1);
            //    stack.Push(2);
            //    stack.Push(3);

            //    while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            //}

            ////큐
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //while(queue.Count>0)
            //{
            //    Console.WriteLine(queue.Dequeue()); // 꺼냄
            //}

            ////큐2
            //Queue queue2 = new Queue();

            //queue.Enqueue("→");
            //queue.Enqueue("↓");
            //queue.Enqueue("↘");
            //queue.Enqueue("→");
            //queue.Enqueue("풍신권");



            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}


            //Console.WriteLine(queue.Count);




            ////Arraylist 생성
            ////크기가 동적으로 조정되는 배열, 다양한 형식의 데이터를 저장할수있다.//

            //ArrayList arrayList = new ArrayList();

            ////요소 추가
            //arrayList.Add(1); // 정수
            //arrayList.Add("Hello"); //문자열
            //arrayList.Add(3.14); // 실수
            ////요소 접근
            //Console.WriteLine("ArrayList 요소 :");
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            ////요소 제거
            //arrayList.Remove(1);

            //Console.WriteLine("\n ArrayList요소 제거 후: ");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}




            //Hashtable 클래스
            //키 -값 쌍을 저장하는 컬렉션이다.
            //키를 이용해 값을 빠르게 검색

            Hashtable hashtable = new Hashtable();

            //키-값 쌍 추가
            hashtable["Alice"] = 25;
            hashtable["Bob"] = 30;
            hashtable["포션"] = 20;

            Console.WriteLine("Hashtable 요소 :");
            foreach(DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key : {entry.Key},Value : {entry.Value}");
            }

            //특정 키의 값 가져오기
            Console.WriteLine($"\n Alice의 나이 : {hashtable["Alice"]}\n");

            //요소제거
            hashtable.Remove("Bob");

            Console.WriteLine("Hashtable 요소:");

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            }


        }
    }
}
