using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] options = { "새 게임", "이어하기", "설정", "종료" };
            int selectedIndex = 0;

            ConsoleKeyInfo keyInfo;
            void PlayGame()
            {

            }

            while (true)
            {
                Console.Clear(); // 화면을 지움
                Console.WriteLine("메뉴를 선택하세요 (↑↓ 이동, Enter 선택)\n");

                // 선택지를 출력
                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; // 선택된 항목 강조
                        Console.WriteLine($"> {options[i]} <");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {options[i]}  ");
                    }
                }

                keyInfo = Console.ReadKey(true); // 키 입력 받기 (true = 화면에 입력 안 보이게)

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:    // 위 방향키
                        selectedIndex = (selectedIndex == 0) ? options.Length - 1 : selectedIndex - 1;
                        break;
                    case ConsoleKey.DownArrow:  // 아래 방향키
                        selectedIndex = (selectedIndex == options.Length - 1) ? 0 : selectedIndex + 1;
                        break;
                    case ConsoleKey.Enter:      // 엔터 키
                        Console.Clear();
                        PlayGame();
                        return; // 프로그램 종료 또는 다음 로직 실행
                }
            }
        }
    }

}
