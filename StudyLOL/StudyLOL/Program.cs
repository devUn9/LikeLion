using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Linq;

namespace StudyLOL
{
    class Champion
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double Armor { get; set; }

        public virtual void Attack(Champion target)
        {
            Console.WriteLine($"{Name}이 기본 공격을 합니다. ");
        }

        // 피해 계산 메서드
        public bool TakeDamage(double damage)
        {
            
            // 방어력에 따른 피해 감소율 계산
            double damageReduction = Armor / (Armor + 100);

            // 실제 입을 피해 계산 (데미지 * (1 - 피해 감소율))
            double actualDamage = Math.Round(damage * (1 - damageReduction), 0);

            // 체력 감소
            Health -= actualDamage;

            if(Health <= 0)
            {
                Health = 0;
                Console.WriteLine($" 가한 피해: {(actualDamage)}, {Name}의 남은 체력: {Health}");
                Console.WriteLine($" {Name}이(가) 당했습니다.");
                return true;
            }
            else
                Console.WriteLine($" 가한 피해: {(actualDamage)}, {Name}의 남은 체력: {Health}");
                return false;
            
        }
    }


class Vayne : Champion
    {
        public double AttackPower { get; set; }

        public override void Attack(Champion target)
        {
            Console.WriteLine($"\n 베인이 {target.Name}에게 화살을 쏘며 공격합니다.");

        }

        public Vayne()
        {
            Name = "베인";
            Health = 2000;
            Armor = 100;

            AttackPower = 450;
        }

    }
    

    class Garen : Champion
    {
        public Garen()
        {
            Name = "가렌";
            Health = 2000;
            Armor = 500;
        }

    }
    class Teemo : Champion
    {
        public Teemo()
        {
            Name = "티모";
            Health = 800;
            Armor = 50;
        }
    }

    class Die
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 챔피언 생성
            Vayne vayne = new Vayne();
            Garen garen = new Garen();
            Teemo teemo = new Teemo();

            while(true)
            {
                vayne.Attack(garen);
                bool garenIsDead = garen.TakeDamage(vayne.AttackPower);
                Thread.Sleep(1000);

                if (garenIsDead)
                {
                    break;  // 가렌이 죽으면 반복문 종료
                }

  
                vayne.Attack(teemo);
                bool teemoIsDead = teemo.TakeDamage(vayne.AttackPower);
                Thread.Sleep(1000);

                if (teemoIsDead)
                {
                    break;  // 티모가 죽으면 반복문 종료
                }

            }
        }
    }
}
