using Module_2;

internal class Program
{
    public static void Main(string[] args)
    {
        //# Исключение и обработка.
        // Задача 1: Деление на ноль

        static int Divide()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter first number:\t");

                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number:\t");

                    int num2 = int.Parse(Console.ReadLine());

                    return num1 / num2;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Not possible to divide by 0");

                    Console.WriteLine("Try again");

                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Only numbers can be entered");

                    Console.WriteLine("Try again");

                    continue;
                }

            }
        }

        Console.WriteLine("\n#TryCatch №1\n");

        Console.WriteLine(Divide());

        // Задача 2: Обработка исключения , открытие файла

        static void FileReader()
        {
            try
            {
                File.Open("Important.txt", FileMode.Open);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }

        }

        // Задача 3: Обработка ошибок при парсинге чисел

        static int Converter()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter number:\t");

                    return Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Try again");

                    continue;
                }

            }

        }

        Console.WriteLine("\n#TryCatch №3\n");

        Console.WriteLine(Converter());

        //Задача 1: Расширение для строк

        string text = "“Granny shifting, not double-clutching like you should”";

        Console.WriteLine("\n#Extension №1\n");

        text.WordCounter();

        // Задача 2: Расширение для чисел

        int number = 241285;

        bool isEven = number.IsEven();

        Console.WriteLine("\n#Extension №2\n");

        Console.WriteLine($"{number} is even: {isEven}");

        // Задача 3: Расширение для списков

        List<string> names = new List<string>()
        {"John", "Corey", "Michael", "Gideon", "Phoenix", "Donna", "Ramil", "John", "Phoenix"};

        List <string> uniqNames = names.GetListOfUniqNames();

        Console.WriteLine("\n#Extension №3\n");

        foreach (var name in uniqNames)
        {
            Console.WriteLine(name);
        }

    }


}






