using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studytop
{
    class Program
    {
        static void Main(string[] args)
        {

            //구구단 2 x 1 = 2 ~ 9x9 = 81 정답
            //for(int j = 1; j < 10; j++)
            //{
            //    for (int i = 2; i < 10; i++)
            //    {
            //        Console.Write($"{i} x {j} = {i*j}\t");

            //    }
            //    Console.WriteLine();
            //}

            ////while문 숫자 1에서 5까지 출력하고 종료 정답
            //int count = 1;
            //while(count<=5)
            //{
            //    Console.WriteLine(count);
            //    count += 1;
            //    //Console.WriteLine(count++);
            //}

            ////같은 답
            //int number = 1;
            //while(true)
            //{
            //    if (number == 5) break;
            //    number++;
            //    Console.WriteLine(number);
            //}

            ////1~10 합 구하기 팩토리얼 아닌 합
            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;


            //}
            //Console.WriteLine("합 : " + sum);


            //가위바위보
            //if, switch, while문 중 사용
            //나는 1~3번으로 선택, 상대는 랜덤

            // 1 주먹 2 가위 3 보  1이 2 이김 2가 3 이김 3이 1 이김.
            //int select1 = 1;
            //select1 = int.Parse(Console.ReadLine());
            //Random rand = new Random();
            //int select2 = rand.Next(1, 4); // 1~3 랜덤 정수 선택
            //int result = 0;
            //while (true)
            //    if (select1 == 1)
            //        Console.WriteLine("주먹을 냈습니다.");
            //    else if (select1 == 2)
            //        Console.WriteLine("가위를 냈습니다.");
            //    else Console.WriteLine("보를 냈습니다.");

            //if (select2 == 1)
            //    Console.WriteLine("컴퓨터가 주먹을 냈습니다.");
            //else if (select2 == 2)
            //    Console.WriteLine("컴퓨터가 가위를 냈습니다.");
            //else Console.WriteLine("컴퓨터가 보를 냈습니다.");

            //if (select1 == select2)
            //    result = 0; // 무승부
            //else if ((select1 == 1 && select2 == 2) || // 주먹 > 가위
            //         (select1 == 2 && select2 == 3) || // 가위 > 보
            //         (select1 == 3 && select2 == 1))   // 보 > 주먹
            //    result = 2; // 승리
            //else
            //    result = 1; // 패배


            //switch (result)
            //{
            //    case 0:
            //        Console.WriteLine("무승부");
            //        break;
            //    case 1:
            //        Console.WriteLine("패배");
            //        break;
            //    case 2:
            //        Console.WriteLine("승리");
            //        break;

            //}



            /// 
            /// // 가위, 바위, 보 게임을 만들건데
            // if, switch, while문을 사용해서 (둘중에 아무거나 if나 switch)
            // 나는 1~3번으로 선택해서 가위바위보를 선택하고 상대는 랜덤으로 가위바위보를해서
            // 내가 이겼는지 비겻는지 졌는지
            // 만들고 쉬는시간까지해서 7시 30분
            // 시간부족하다 말씀해주시면 조금 더드려볼게요 일단 30분풀어보시고
            // 지피티쓰면안되요

            // 풀만하신가요? 어렵나요?
            // 가위바위보...생각보다어렵네..?
            /*
            Random random = new Random();

            while (true)
            {
                Console.WriteLine("========가위바위보 게임========");
                Console.WriteLine("1:가위, 2:바위, 3:보");
                Console.WriteLine("숫자를 입력하세요 :) (0번을 입력하면 게임이 종료됩니다)");

                string input = Console.ReadLine();
                int useChoice;
                try
                {
                    useChoice = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("잘못된 입력입니다. 숫자를 입력하세요.\n");
                    continue;
                }

                if (useChoice == 0) break;

                if (useChoice < 1 || useChoice > 3)
                {
                    Console.WriteLine("1,2,3중 하나의 숫자를 입력하세요\n");
                    continue;
                }


                int computerChoice = random.Next(1, 4);



                string userMove = "";
                //if (useChoice == 1) userMove = "가위";
                //else if (useChoice == 2) userMove = "바위";
                //else if (useChoice == 3) userMove = "보";

                string computerMove = "";
                //if (computerChoice == 1)
                //{
                //    computerMove = "가위";
                //    Console.WriteLine(computerMove);
                //}
                //else if (computerChoice == 2) computerMove = "바위";
                //else if (computerChoice == 3) computerMove = "보";

                switch (useChoice)
                {
                    case 1: userMove = "가위"; break;
                    case 2: userMove = "바위"; break;
                    case 3: userMove = "보"; break;
                }

                switch (computerChoice)
                {
                    case 1: computerMove = "가위"; break;
                    case 2: computerMove = "바위"; break;
                    case 3: computerMove = "보"; break;
                }

                Console.WriteLine($"나 : {userMove}, 컴퓨터 : {computerMove}");

                if (useChoice == computerChoice)
                {
                    Console.WriteLine("비겼슴둥...\n");
                }
                else if ((useChoice == 1 && computerChoice == 3) ||
                        (useChoice == 2 && computerChoice == 1) ||
                        (useChoice == 3 && computerChoice == 2))
                {
                    Console.WriteLine("이겼슴둥!!!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("졌슴둥......ㅠㅠ\n");
                }
            }
            */ //정답



            //while 문제
            //컴퓨터가 랜덤 1 ~100까지 숫자를 내가 10번안에 맞추기
            Random rand = new Random();
            int answer = rand.Next(1, 101);
            
            int select = 0;
            int opportunity = 10;
            while (answer != select)
            {
                if (opportunity == 0)
                {
                    Console.WriteLine(" 기회를 다 썼습니다! Game Over!");
                    break;
                }
                else
                {
                    Console.WriteLine($" 남은 기회 : {opportunity}\n");
                    opportunity--;


                    Console.Write(" 숫자를 입력하세요. : ");
                    select = int.Parse(Console.ReadLine());



                    if (select > answer)
                    {
                        Console.WriteLine(" 더 작은 수입니다.");
                        
                    }
                    else if (select < answer)
                    {
                        Console.WriteLine(" 더 큰 수입니다.");
                        
                    }

                    else Console.WriteLine($" 정답입니다! {10-opportunity}번 만에 맞히셨네요!");
                }
            }


            //예외처리 gpt 도와줌

            //Random rand = new Random();
            //int answer = rand.Next(1, 101);
            //int select = 0;
            //int opportunity = 10;

            //while (answer != select)
            //{
            //    if (opportunity == 0)
            //    {
            //        Console.WriteLine("기회를 다 썼습니다! GAME OVER!");
            //        break;
            //    }

            //    Console.WriteLine($"남은 기회 : {opportunity}\n");
            //    opportunity--;

            //    while (true) // 올바른 입력이 나올 때까지 반복
            //    {
            //        Console.Write("숫자를 입력하세요 (1~100) : ");
            //        try
            //        {
            //            select = int.Parse(Console.ReadLine());

            //            if (select < 1 || select > 100)
            //            {
            //                Console.WriteLine("⚠ 1~100 사이의 숫자를 입력하세요!");
            //                continue;
            //            }
            //            break; // 올바른 입력이면 while 탈출
            //        }
            //        catch (FormatException)
            //        {
            //            Console.WriteLine("⚠ 숫자만 입력하세요!");
            //        }
            //    }

            //    if (select > answer)
            //    {
            //        Console.WriteLine("더 작은 수입니다.");
            //    }
            //    else if (select < answer)
            //    {
            //        Console.WriteLine("더 큰 수입니다.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"🎉 정답입니다! {10 - opportunity}번 만에 맞히셨네요!");
            //    }
            //}



        }
    }
}
