using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study16_2
{
    class Program
    {
        enum WeaponType
        {
            Sword,
            Bow,
            Staff
        }

        static void ChooseWeapon(WeaponType weapon)
        {
            if(weapon==WeaponType.Sword)
            {
                Console.WriteLine("검을 선택했습니다.");

            }
            else if (weapon==WeaponType.Bow)
            {
                Console.WriteLine("활을 선택했습니다.");
            }
            else if (weapon == WeaponType.Staff)
            {
                Console.WriteLine("지팡이 선택했습니다.");
            }
        }

        static void Main(string[] args)
        {
            ChooseWeapon(WeaponType.Sword);
        }
    }
}
