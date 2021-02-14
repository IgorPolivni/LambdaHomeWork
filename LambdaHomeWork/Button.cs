using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateHomeWork
{

    public delegate void Handlers(params object[] objects);
    class Button
    {
        public char Border { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }
        public ConsoleColor InternalColor { get; set; }
        public ConsoleColor BorderColor { get; set; }
        public event Action<object> MyAction;


        private void PrintBorderLine()
        {

            Console.ForegroundColor = BorderColor;
            for (int i = 0; i < Width; i++)
                Console.Write(Border);

            Console.WriteLine();
        }

        private void PrintBorderOrSpace(int index)
        {
            if (index == 0 || index == Width - 1)
                Console.Write(Border);
            else
                Console.Write(" ");
        }

        public void Print()
        {
            bool isPrintText = false;
            PrintBorderLine();
            ConsoleColor standartColor = Console.ForegroundColor;
            Console.ForegroundColor = standartColor;
            for (int i = 0; i < Height; i++)
            {
                if (i >= Height / 2 && !isPrintText)
                {
                    for (int j = 0; j <= Width; j++)
                    {
                        if (j >= Width / 3 && !isPrintText)
                        {
                            Console.ForegroundColor = InternalColor;
                            Console.Write(Text);
                            Console.ForegroundColor = BorderColor;
                            j += Text.Length - 1;
                            isPrintText = true;
                        }
                        else
                        {
                            PrintBorderOrSpace(j);
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Width; j++)
                    {
                        PrintBorderOrSpace(j);
                    }
                }
                Console.WriteLine();
            }

            PrintBorderLine();
            Console.ForegroundColor = standartColor;
        }

    }
}
