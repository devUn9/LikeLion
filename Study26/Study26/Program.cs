using System;
using System.Linq;

namespace Study26
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Charlie", "Alice", "Bob" };
            //var sortedNames = names.OrderBy(n => n);
            ////int Identity(int n)
            ////{
            ////    return n;
            ////}

            //foreach(var name in sortedNames)
            //{
            //    Console.WriteLine(name);
            //}

            //var firstName = names.First(n => n.StartsWith("A"));

            //Console.WriteLine($"First name starting with A : {firstName}"); //Alice

            //// 배열형식으로 출력해보기
            ////string[] sortedNames2 = names.OrderBy(n => n).ToArray();
            ////for (int i= 0 ;i < sortedNames2.Length;i++)
            ////    Console.WriteLine(sortedNames2[i]);




            ////메서드 구문, 쿼리 구문
            //int[] nums = { 5, 3, 8, 1 };
            ////메서드 구문
            //var sortedMethod = nums.OrderBy(n => n);
            ////쿼리 구문
            //var sortedQuery = from n in nums
            //                  orderby n
            //                  select n;
            //Console.WriteLine("Method Syntax:");
            //foreach (var n in sortedMethod)
            //    Console.WriteLine(n);
            //Console.WriteLine("Method Syntax:");
            //foreach (var n in sortedQuery)
            //    Console.WriteLine(n);



            //string[] words = { "apple", "banana", "cherry" };
            ////Select로 길이 추출
            ////Linq 쿼리 연산자 중 하나
            //// 각 요소를 변환하여 새로운 컬렉션을 생성
            //var lengths = words.Select(w => w.Length);

            //foreach(var length in lengths)
            //{
            //    Console.WriteLine(length);
            //}

            //var upperWords = words.Select(w => w.ToUpper());
            //foreach(var word in upperWords)
            //{
            //    Console.WriteLine(word);
            //}


            ////sum 알고리즘, 배열
            //int[] data = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //foreach (int d in data)
            //    sum += d;
            //Console.WriteLine($"Sum : {sum}");


            ////count
            //int[] data = { 1, 2, 3, 4, 5 };
            //int count = data.Length; // 개수
            //Console.WriteLine($"count : {count}");


            ////평균
            //float[] data = { 80, 70, 61 };
            //double avg = data.Average();
            //Console.WriteLine($"Average : {avg:F2}");


            ////최대,최소
            //int[] data = { 55, 76, 65 };
            //int max = data.Max();
            //Console.WriteLine($"Max : {max}");
            //int min = data.Min();
            //Console.WriteLine($"Min : {min}");


            ////근삿값 구하기 : NEAR 알고리즘
            ////배열에서 특정 값에 가장 가까운 값을 찾는 예제
            //int[] data = { 10, 12, 20, 25, 30 };
            //int target = 22;
            //int nearest = data[0];

            //foreach (var d in data)
            //{
            //    if (Math.Abs(d - target) < Math.Abs(nearest - target))
            //        nearest = d;
            //}
            //Console.WriteLine($"Nearest to {target} : {nearest}");


            ////순위 구하기 : RANK 알고리즘
            ////각 요소가 몇번째로 큰지 순위를 매기는 얘제
            //int[] scores = { 90, 70, 50, 70, 60 };
            //for(int i =0;i<scores.Length;i++)
            //{
            //    int rank = 1;
            //    for(int j=0; j<scores.Length;j++)
            //    {
            //        if (scores[j] > scores[i])
            //            rank++;
            //    }
            //    Console.WriteLine($"Score : {scores[i]}, Rank: {rank}");
            //}

            //배열 정렬함수
            //int[] data = { 5, 2, 8, 1, 9 };
            //Array.Sort(data);
            //foreach (var d in data)
            //    Console.WriteLine(d);


            ////특정 값 검색하기 : Search 알고리즘
            //int[] data = { 5, 2, 8, 1, 9 };
            //int target = 8, index = -1;

            //for(int i =0;i<data.Length;i++)
            //{
            //    if (data[i] == target)
            //    {
            //        index = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(index >= 0 ? $"Found at index{index}" : "Not found");

            //그룹화 하기 : GROUP 알고리즘
            //데이터를 특정 기준으로 그룹화하기

            string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };
            var groups = fruits.GroupBy(f => f[0]); //첫 글자로 그룹화

            foreach (var group in groups)
            {
                Console.WriteLine($"Key : {group.Key}");

                foreach (var item in group)
                {
                    Console.WriteLine($"{item}");
                }

            }
        }
    }
}
