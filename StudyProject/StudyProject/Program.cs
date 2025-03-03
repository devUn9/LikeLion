using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            // 세 개 이상의 정수를 입력받음
            string[] numbers = Console.ReadLine().Split();
            List<int> iNumbers = new List<int>();

            // 입력받은 문자열을 정수 리스트로 변환
            foreach (var num in numbers)
            {
                iNumbers.Add(int.Parse(num));
            }

            // GetMaxNumber 함수 호출하고 가장 큰 수 출력
            Console.WriteLine($"가장 큰 수 : {GetMaxNumber(iNumbers)}");
        }

        // List<int>를 인자로 받는 함수
        static int GetMaxNumber(List<int> numbers)
        {
            int max = numbers[0];  // 첫 번째 값을 기준으로 설정

            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
            }

            return max;
        }
    }

}
