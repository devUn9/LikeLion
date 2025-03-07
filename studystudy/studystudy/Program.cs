using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studystudy
{
    class Program
    {
        static void Main(string[] args)
        {
            
        // 정수형 타입을 가진 List를 만듬
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        
        // IEnumerable<int>를 사용하여 리스트를 순회
        IEnumerable<int> enumerableNumbers = numbers;
        
        foreach (var number in enumerableNumbers)
        {
            Console.WriteLine(number);  // 출력: 1, 2, 3, 4, 5
        }
        }
    }
}
