using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventory
{
    class Program
    {
        //최대 아이템 개수 (배열 크기)
        const int MAX_ITEMS = 10;

        //아이템 배열 (이름 저장)
        static string[] itemNames = new string[MAX_ITEMS];
        static int[] itemCounts = new int[MAX_ITEMS];

        //아이템 추가 함수
        static void AddItem(string name, int count)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == name)
                {
                    itemCounts[i] += count;
                    return;
                }
            }
            // 빈 슬롯에 새로운 아이템 추가
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == null)
                {
                    itemNames[i] = name;
                    itemCounts[i] = count;
                    return;
                }
            }

            Console.WriteLine("인벤토리가 가득 찼습니다.")
;
        }

        //아이템 제거 함수
        static void RemoveItem(string name, int count)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == name) // 이름 체크
                {
                    if (itemCounts[i] >= count)// 개수 충분하면
                    {
                        itemCounts[i] -= count; //차감
                        if (itemCounts[i] == 0) // 개수가 0이면 삭제
                        {
                            itemNames[i] = null;
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("아이템 개수가 부족합니다 !");
                        return;
                    }
                }
            }
            Console.WriteLine("아이템을 찾을 수 없습니다 !");
        }

        //인벤토리 출력 함수
        static void ShowInventory()
        {
            Console.WriteLine("현재 인벤토리 : ");
            bool isEmpty = true;

            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] != null && itemCounts[i] > 0)
                {
                    Console.WriteLine($"{itemNames[i]} (x{itemCounts[i]})");
                    isEmpty = false;
                }
            }
            if (isEmpty)
            {
                Console.WriteLine("인벤토리가 비어있습니다 !");
            }
        }

        //인벤토리 수정 함수 // ModifyInventory("포션", 0); ModifyInventory("칼", 0);

        static void ModifyInventory(string name, int count)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == name) // 해당 아이템을 찾았을 때
                {
                    if (count == 0) // 개수가 0이면 삭제
                    {
                        itemNames[i] = null; // 이름 배열 초기화
                    }
                    else
                    {
                        itemCounts[i] = count; // 개수 수정
                    }
                    return;
                }
            }

            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == null) //
                {
                    itemNames[i] = name;
                    itemCounts[i] = count;
                    return;
                }
            }
        }

        static void Main(string[] args)
        {
            // 테스트 : 아이템 추가
            Console.WriteLine("포션 8, 칼 1개 추가");
            AddItem("포션", 5);
            AddItem("칼", 1);
            AddItem("포션", 3);
            ShowInventory();
            Console.Write("\n--------------------------\n");


            ////아이템 사용
            //RemoveItem("포션", 2);
            //Console.WriteLine("포션 2개 사용");
            //ShowInventory();
            //Console.Write("\n--------------------------\n");

            ////테스트 : 없는 아이템 제거
            //Console.WriteLine("방패 1개 제거 시도");
            //RemoveItem("방패", 1);
            //ShowInventory();
            //Console.Write("\n--------------------------\n");

            ////테스트 : 모든 포션 제거
            //Console.WriteLine("포션 6개 사용");
            //RemoveItem("포션", 6);
            //ShowInventory();
            //Console.Write("\n--------------------------\n");

            //테스트 : 수정하기 (추가 내용)
            Console.WriteLine("포션 0개, 칼 0개로 수정");
            ModifyInventory("포션", 0);
            ModifyInventory("칼", 0);
            ShowInventory();
            Console.Write("\n--------------------------\n");




        }
    }
}
