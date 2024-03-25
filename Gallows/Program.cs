using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Gallows
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<char> UsedLetters = new List<char>();
           string ChosenWord;
           Console.OutputEncoding = UTF8Encoding.UTF8;
           WordsList words = new WordsList();
           DrawGallow drawGallow = new DrawGallow();
           GameProcess game = new GameProcess();
            int count = 0;

            while (true)
            {
                try
                {
                    int rnd = new Random().Next(0, 49);
                    ChosenWord = words[rnd];
                    char[] bricks = new char[ChosenWord.Length];
                    for (int i = 0; i < bricks.Length; i++)
                    {
                        bricks[i] = '_';
                    }
                    Console.WriteLine("Хочете розпочати гру?\n1 - так\n2 - ні");
                    int choice = int.Parse(Console.ReadLine());


                
                if (choice == 1)
                {
                    while (true)
                    {
                            try
                            {
                                bool IsLetterRight = false;
                                Console.Write("Вам потрібно вгадати слово ");
                                for (int i = 0; i < bricks.Length; i++)
                                {
                                    Console.Write(bricks[i] + " ");
                                }
                                Console.WriteLine();
                                char letter = char.Parse(Console.ReadLine());
                                count++;
                                    for (int i = 0; i < bricks.Length; i++)
                                    {
                                        if (letter == ChosenWord[i])
                                        {
                                            bricks[i] = letter;
                                            IsLetterRight = true;
                                            count--;
                                        }

                                    }
                                if (!UsedLetters.Contains(letter))
                                {
                                    UsedLetters.Add(letter);
                                    Console.Write("Використані літери ");
                                    foreach (var c in UsedLetters)
                                    {
                                        Console.Write(c + ", ");
                                    }
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("Ця літера вже використана, спробуйте ввести другу");
                                    continue;
                                }
                                drawGallow.Draw(IsLetterRight, count);
                                if(IsLetterRight)
                                {
                                    IsLetterRight = false;
                                    drawGallow.Draw(IsLetterRight, count);
                                }
                                if (drawGallow.IsFull)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Ви програли");
                                    Console.WriteLine($"Сховане слово - {ChosenWord}");
                                    Console.ResetColor();
                                    UsedLetters.Clear();
                                    count = 0;
                                    drawGallow.IsFull = false;
                                    game.PersonalRecord = 0;
                                    break;
                                }

                                if (game.IsWin(bricks))
                                {
                                    using (StreamWriter writer = new StreamWriter("Record.txt", true))
                                    {
                                        writer.Write(game.PersonalRecord);
                                    }
                                    using (StreamReader reader = new StreamReader("Record.txt"))
                                    {
                                        string Records = reader.ReadToEnd();
                                        for(int i = 0; i < Records.Length; i++)
                                        {
                                            if (game.PersonalRecord > Records[i])
                                            {
                                                Console.WriteLine("Рекорд побито!!!");
                                            }
                                        }
                                        Console.WriteLine("Ваш рекорд - "+ Records.Max());
                                    }


                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Ви перемогли, наші вітання!!!");
                                    Console.WriteLine($"Сховане слово - {ChosenWord}");
                                    Console.ResetColor();
                                    UsedLetters.Clear();
                                    count = 0;
                                    break;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Вам потрібно ввести всього 1 літеру");
                            }
                    }



                }
                else if (choice == 2)
                {
                    break;
                }
                else
                    break;

                }
              catch
                {
                Console.WriteLine("Спробуйте ввести правильне значення");
                }

        }

        }
    }
}
