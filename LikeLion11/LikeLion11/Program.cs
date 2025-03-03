using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion11
{
    class Program
    {
        static int count = 0; // 정적 메모리에 저장, 프로그램 종료 전까지 유지
        int instan = 200;
        static void Main(string[] args)
        {
            //메모리 영역
            //스택 (stack) - int a
            //힙 - new
            //정적 메모리 - static

            count++;
            Console.WriteLine(count);
            int instan = 10;
            Console.WriteLine(instan);
        
        
        }
    }
}
