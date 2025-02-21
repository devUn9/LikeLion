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
            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine(); // 사용자로부터 입력받기
            //int age = int.Parse(input); //문자열을 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");
            //Console.WriteLine("내년에는" + age + "살이 되겠군요!")
            //;
            //Console.WriteLine("내년에는 {0}살이 되겠군요!", age);

            //루인 스킬 피해 : 4.5% 입력받기

            Console.Write("루인 스킬 피해를 입력하세요: ");
            string input1 = Console.ReadLine();
            float Skill_Damage = float.Parse(input1);

            Console.Write("카드 게이지 획득량: ");
            float Card_Gage = float.Parse(Console.ReadLine());

            Console.Write("각성기 피해: ");
            float Ult_Damage = float.Parse(Console.ReadLine());

            Console.Write("최대 마나: ");
            float Max_Mana = float.Parse(Console.ReadLine());

            Console.Write("전투 중 마나 회복량: ");
            float CombatManaRegen = float.Parse(Console.ReadLine());

            Console.Write("비전투 중 마나 회복량: ");
            float ManaRegenOutofCombat = float.Parse(Console.ReadLine());

            Console.Write("이동 속도: ");
            float MoveSpeed = float.Parse(Console.ReadLine());

            Console.Write("탈것 속도: ");
            float rideSpeed = float.Parse(Console.ReadLine());

            Console.Write("운반 속도: ");
            float CarrySpeed = float.Parse(Console.ReadLine());

            Console.Write("스킬 재사용 대기시간 감소: ");
            float CooldownReduction = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"활동{"▼",41}");
            Console.WriteLine($"루인 스킬 피해 {Skill_Damage,30}%");
            Console.WriteLine($"카드 게이지 획득량 {Card_Gage,26}%");
            Console.WriteLine($"각성기 피해 {Ult_Damage,33}%");
            Console.WriteLine($"최대 마나 {Max_Mana,36}");
            Console.WriteLine($"전투 중 마나 회복량 {CombatManaRegen,26}");
            Console.WriteLine($"비전투 중 마나 회복량 {ManaRegenOutofCombat,24}");
            Console.WriteLine($"이동 속도 {MoveSpeed,35}%");
            Console.WriteLine($"탈 것 속도 {rideSpeed,34}%");
            Console.WriteLine($"운반 속도 {CarrySpeed,35}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 {CooldownReduction,19}%");
      
        }
    }
}
