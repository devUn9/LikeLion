using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion11_2
{
    class Program
    {
        //1단계 기본형
        static void Loading()
        {
            Console.WriteLine("로딩중.");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("로딩중..");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("로딩중...");
            Thread.Sleep(500);
            Console.Clear();

        }

        //2단계 입력
        static void AttackFunction(int _Attack)
        {
            Console.WriteLine("공격력은 : " + _Attack);
        }

        //3단계 출력
        static int BaseAttack()
        {
            //기본 공격력 10
            int attack = 10;

            return attack;
        }
        static void Main(string[] args)
        {
            int Attack = 0;
            int bAttack = 0;

            //Console.WriteLine("로딩화면");
            Loading();

            Console.WriteLine("캐릭터의 공격력을 입력 : ");
            Attack = int.Parse(Console.ReadLine());
            //AttackFunction(Attack);
            
            //기본 공격력
            bAttack = BaseAttack();
            AttackFunction(bAttack + Attack);
        }
    }
}
