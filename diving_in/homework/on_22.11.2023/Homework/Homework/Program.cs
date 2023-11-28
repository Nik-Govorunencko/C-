namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(args[0], out int num1);
            int.TryParse(args[2], out int num2);
            string typeOfSolv = args[1];
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
