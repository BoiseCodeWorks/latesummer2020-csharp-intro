using System;

namespace calculator.Models
{
    public class Calculator
    {

        public bool Selecting { get; private set; } = true;
        public string Title { get; set; }


        public Calculator(string title)
        {
            Selecting = true;
            Title = title;
            Init();
        }

        private void Init()
        {
            System.Console.WriteLine($"Welcome to the {Title}!");
            Selecting = true;
            Menu();
        }

        private void Menu()
        {
            Selecting = true;
            while (Selecting)
            {
                System.Console.WriteLine("Make a selection:");
                System.Console.WriteLine("1. Add Two numbers 2. Subtract two numbers, Q. Quit");
                string userInput = Console.ReadLine();
                System.Console.WriteLine(userInput);
                switch (userInput.ToLower())
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Subtract();
                        break;
                    case "q":
                    case "quit":
                        Selecting = false;
                        break;
                    default:
                        System.Console.WriteLine("Invalid selection.");
                        break;
                }
            }
        }

        private void Subtract()
        {
            throw new NotImplementedException();
        }

        private void Add()
        {
            System.Console.Write("input your first number to add:");
            string userInput = Console.ReadLine();
            System.Console.Write("input your second number to add:");
            string userInput2 = Console.ReadLine();

            int num2;
            int.TryParse(userInput, out int num1);
            int.TryParse(userInput2, out num2);


            System.Console.WriteLine(num1 + num2);

        }

        private void Add(int num1, int num2)
        {
            System.Console.WriteLine(num1 + num2);
        }
        private void Add(string num1, string num2)
        {
            int number2;
            int.TryParse(num1, out int number1);
            int.TryParse(num2, out number2);
            System.Console.WriteLine(number1 + number2);
        }
    }
}