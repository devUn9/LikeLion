﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study15
{   
    
    class Program
    {
        //일반적인 함수
        static int Add(int a, int b)
        {
            return a + b;
        }

        //화살표 함수
        static int AddArrow(int a, int b) => a + b;


        //일반 함수
        static void PrintMessage()
        {
            Console.WriteLine("안녕하세요!");
        }

        //화살표 함수
        static void PrintMessageArrow() => Console.WriteLine("안녕하세요!");
        
        static void Main(string[] args)
        {
            // C# 화살표 함수 
            // 람다 표현식이라고도 하며
            // 간결한 방식으로 함수를 정의할 수 있다.
            Console.WriteLine(Add(3, 5));
            Console.WriteLine(AddArrow(3, 5));

            PrintMessage();
            PrintMessageArrow();

        }
    }
}
