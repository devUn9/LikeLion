using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task250306
{
    public class Mega : Coffee
    {
        
        public override void Buy()
        {
            Console.WriteLine($"{name}커피에 {Price}원을 지불하고 커피를 마십니다.");
        }
        public override void Drink()
        {
            Console.WriteLine($"{Beans}의 풍미가 느껴집니다.");
        }
        public override void Attack(Coffee target)
        {
            Console.WriteLine($"{name}커피가 {target.name}커피는 맛이 없다고 소문냅니다.");
        }
    }
}
