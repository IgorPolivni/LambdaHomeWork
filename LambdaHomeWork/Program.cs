using System;

namespace DelegateHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor standartBackGroundColor = Console.BackgroundColor;
            ConsoleColor standartTextColor = Console.ForegroundColor;


            Button button = new Button
            {
                Border = '+',
                Height = 3,
                Text = "Мир",
                Width = 15,
                BorderColor = ConsoleColor.Green,
                InternalColor = ConsoleColor.Red
            };

            button.MyAction += x => { MyFirstMethod(x); };
            button.MyAction += x => { MySecondMethod(x); };
            button.Print();

            Console.BackgroundColor = standartBackGroundColor;
            Console.ForegroundColor = standartTextColor;
        }

        private static void MyFirstMethod(object o) { }
        private static void MySecondMethod(object o) { }
    }
}
