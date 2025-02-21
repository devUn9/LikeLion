using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//사용자 입력을 문자열 받기
            Console.Write("이름을 입력하세요: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"안녕하세요, {userName}님!");*/

            //문자열을 정수로 변환
            Console.Write("나이를 입력하세요: ");
            string input = Console.ReadLine(); // 사용자로부터 입력받기
            int age = int.Parse(input); //문자열을 정수로 변환

            Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");
            
        }
    }
}
