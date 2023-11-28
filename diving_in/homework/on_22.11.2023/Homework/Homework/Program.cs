namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три параметра. Первый - число, второй - число, третий - тип вычесления (+; -; /; *) ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string typeOfSolv = Console.ReadLine();
            int result = 0;
            if (typeOfSolv == "+")
            {
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
            }
            else if (typeOfSolv == "-")
            {
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
            }
            else if (typeOfSolv == "*")
            {
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
            }
            else if (typeOfSolv == "/")
            {
                if (num2 == 0) 
                { 
                    Console.WriteLine("Вы пытаетесь делить на ноль!"); 
                    Environment.Exit(0); 
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result}");
                }
            }
            else
            {
                Console.WriteLine("Похоже вы ввели что-то неправильно, попробуйте снова!");
            }
        }
    }
}
