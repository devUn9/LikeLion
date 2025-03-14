using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250310_연습
{
    class Program
    {
        
            static void Main(string[] args)
            {
                // 1~9까지 숫자를 저장할 변수 (배열이던, list던)
                List<int> number = new List<int>();
                for (int i = 1; i <= 9; i++)
                {
                    number.Add(i);
                }

                int boardSize = 3;
                int[,] board = new int[boardSize, boardSize];
                bool[,] marked = new bool[boardSize, boardSize];
                int index = 0;

                for (int i = 0; i < boardSize; i++)
                {
                    for (int j = 0; j < boardSize; j++)
                    {
                        board[i, j] = number[index++];
                        marked[i, j] = false;
                    }
                }


                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("현재 빙고판 : ");

                    PrintBoard(board, marked);

                    Console.WriteLine("\n마킹할 번호를 입력하세요 : ");
                    string input = Console.ReadLine();
                    int inputNumber;
                    if (!int.TryParse(input, out inputNumber))
                    {
                        Console.WriteLine("유효한 숫자를 입력하세요.");
                        Console.ReadLine();
                        continue;
                    }

                    bool found = false;
                    for (int i = 0; i < boardSize; i++)
                    {
                        for (int j = 0; j < boardSize; j++)
                        {
                            if (board[i, j] == inputNumber)
                            {
                                if (!marked[i, j])
                                {
                                    marked[i, j] = true;
                                    found = true;
                                }
                                else
                                {
                                    Console.WriteLine("이미 마킹된 숫자입니다.");
                                    found = true;
                                }
                            }
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("입력한 숫자가 빙고판에 없습니다.");
                        Console.ReadLine();
                    }

                    // 아래함수가 빙고줄이 완성 되엇는지 확인
                    if (CheckBingo(marked))
                    {
                        Console.Clear();
                        Console.WriteLine("현재 빙고판 : ");

                        PrintBoard(board, marked);

                        Console.WriteLine("\n빙고! 한 줄이 완성 되었습니다. 게임오버!");
                        break;
                    }

                }

            }

            static void PrintBoard(int[,] board, bool[,] marked)
            {
                int row = board.GetLength(0);
                int col = board.GetLength(1);

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (marked[i, j])
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write(board[i, j].ToString());
                        }
                    }
                    Console.WriteLine();
                }
            }

            static bool CheckBingo(bool[,] marked)
            {
                int size = marked.GetLength(0);

                // 행 검사 (한줄이 완성 되엇는지)
                for (int i = 0; i < size; i++)
                {
                    bool rowComplete = true;
                    for (int j = 0; j < size; j++)
                    {
                        if (!marked[i, j])
                        {
                            rowComplete = false;
                            break;
                        }
                    }
                    if (rowComplete) return true;
                }

                // 열 검사 (한줄이 완성 되었는지)
                for (int i = 0; i < size; i++)
                {
                    bool colComplete = true;
                    for (int j = 0; j < size; j++)
                    {
                        if (!marked[j, i])
                        {
                            colComplete = false;
                            break;
                        }
                    }
                    if (colComplete) return true;
                }

                // 대각선 검사 (좌상 우하) 
                bool diagComplete = true;
                for (int i = 0; i < size; i++)
                {
                    if (!marked[i, i])
                    {
                        diagComplete = false;
                        break;
                    }
                }

                if (diagComplete) return true;


                // 대각선 검사 (우상 좌하)
                bool diagComplete2 = true;
                for (int i = 0; i < size; i++)
                {
                    if (!marked[i, size - 1 - i])
                    {
                        diagComplete2 = false;
                        break;
                    }
                }

                if (diagComplete2) return true;


                return false;
            }
        }
    }
