using System.ComponentModel.Design;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        /* Цикл FOR
        1. Создайте цикл for, который выводит числа от 1 до 10 на консоль.
        2. Добавьте условие if-else внутри цикла, чтобы проверить, 
        является ли текущее число четным или нечетным. (гуглим как)
        3. Выведите сообщение в консоль "Число [число] является четным" или "Число [число]
        является нечетным" в зависимости от результата проверки.*/
        
        byte[] numbers = new byte[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        for (byte i = 0; i < 10; i++)
            if ((numbers[i] % 2) == 0) Console.WriteLine($"Number {numbers[i]} is even");
            else Console.WriteLine($"Number {numbers[i]} is odd");
        Console.WriteLine();
        /*Цикл WHILE
        1. Инициализируйте переменную count со значением 1.
        2. Создайте цикл while, который будет выполняться до тех пор, 
        пока значение count не превысит 10.
        3. Внутри цикла добавьте условие if-else, чтобы проверить, 
        является ли текущее число кратным 3. (гуглим)
        4. Выведите сообщение "Число [число] кратно 3" или "Число [число] 
        не кратно 3" в зависимости от результата проверки. */
        byte count = 1;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        while (count <= 10)
            if ((count % 3) == 0) {Console.WriteLine($"Number {count} is multiple 3");count++; }
            else {Console.WriteLine($"Number {count} is not multiple 3"); count++; }
        Console.WriteLine();
        /*Цикл DO WHILE
        1. Инициализируйте переменную guess со значением 0.
        2. Создайте цикл do-while, который будет выполняться, 
        пока значение guess не станет равным 5.
        3. Внутри цикла запрашивайте у пользователя число, 
        сохраняйте его в переменную guess. (используйте следующий снипет)
        4. Добавьте условие if-else, чтобы проверить, является ли guess 
        больше или меньше или равно 5.
        5. Выведите сообщение "Загаданное число меньше" или "Загаданное число больше" 
        и “Угадали! (прервать цикл)”в зависимости от результата проверки. 
        Примечание - цикл выполняется бесконечно пока пользователь не введет 5 - 
        выход осуществляем с помощью break*/
        byte guess = 0;
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        do
        {
        Console.WriteLine("Try guess, write number:");
        guess = Convert.ToByte(Console.ReadLine());
            if (guess > 5) Console.WriteLine("Your number is higher");
            else if (guess < 5) Console.WriteLine("Your number is lower");
            else { Console.Clear(); Console.WriteLine("Congratulations, you guessed right"); }
        }
        while (guess != 5); // Думаю что в 'break' нет необходимости, т.к. при числе равном 5 программа и так выключиться.
                           // Единственное что не обезопасил себя от ввода отличного от числа и за пределами 'byte'
        Console.WriteLine();
        /*Цикл FOREACH
        1. Создайте массив numbers со значениями: 10, 20, 30, 40, 50.
        2. Используя цикл foreach, переберите каждый элемент массива numbers.
        3. Добавьте условие if-else, чтобы проверить, является ли текущий элемент 
        больше 30 или меньше или равен 30.
        4. Выведите сообщение "Элемент [элемент] больше 30" или "Элемент [элемент]
        меньше или равен 30" в зависимости от результата проверки.*/
        byte[] Numbers = new byte[5] {10, 20, 30, 40, 50};
        Console.ForegroundColor= ConsoleColor.DarkGray;
        foreach (byte Number in Numbers)
        {
            if (Number < 30) Console.WriteLine($"{Number} smaller than 30");
            else if (Number == 30) Console.WriteLine($"{Number} equals 30");
            else if (Number > 30) Console.WriteLine($"{Number} bigger than 30");
        }
        }
        

    }

}   
    
