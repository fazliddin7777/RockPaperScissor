using System.Net.Quic;


class Program
{
    public static void Main()
    {
        void Menu()
        {
            System.Console.WriteLine("Calculator");
            System.Console.WriteLine("1.Perform a calculation");
            System.Console.WriteLine("2.View calculation history");
            System.Console.WriteLine("3.Exit");
            System.Console.Write("Choose an option: ");
        }

        for(int a = 0; ; )
        {
            string result = "";
            string history = "";
            Menu();
            int menu = int.Parse(Console.ReadLine());

            if(menu == 1)
            {
                Console.Write("Enter the first number: ");
                double number1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                double number2 = int.Parse(Console.ReadLine());
                Console.Write("Choose an arifmetic operations(+, -, *, /): ");
                char belgi = char.Parse(Console.ReadLine());
                switch(belgi)
                {
                    case '+':
                    result = ($"{number1} + {number2} = {number1 + number2}");
                    Console.WriteLine(result);
                    history += result;
                    break;
                    case '-':
                    result = ($"{number1} - {number2} = {number1 - number2}");
                    Console.WriteLine(result);
                    history += result;
                    break;
                    case '*':
                    result = ($"{number1} * {number2} = {number1 * number2}");
                    Console.WriteLine(result);
                    history += result;
                    break;
                    case '/':
                    result = ($"{number1} / {number2} = {number1 / number2}");
                    Console.WriteLine(result);
                    history += result;
                    break;
                    default:
                    Console.WriteLine("Invalid operations!");
                    break;
                    history = result;
                }
            }
            if(menu == 2)
            {
                System.Console.WriteLine(history);
            }
            if(menu == 3)
            {
                Console.Write("Exciting...");
                break;
            }
        }
    }
}