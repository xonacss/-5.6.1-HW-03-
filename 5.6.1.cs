using System;
using System.Collections.Generic;

class MainClass
{
    static void Main(string[] args)
    {
        string name = getname();
        string firstname = getfirstname();
        byte age = getnage();

        oprosnik(name, firstname, age);

        end(name, firstname, age);

        Console.WriteLine("Спасибо за опрос!");

        Console.ReadKey();
    }
    static void oprosnik(string name, string firstname, byte age)
    {
        Console.WriteLine("Есть ли у вас питомец? (да/нет)");
        string ans = Console.ReadLine();
        if (ans == "да" || ans == "Да")
        {
            Console.WriteLine("Сколько у вас питомцев?");
            short kolvopit = short.Parse(Console.ReadLine());

            string[] klichki = new string[kolvopit];
            for (int i = 0; i < kolvopit; i++)
            {
                Console.WriteLine("Введите кличку {0}(ого) питомца", i + 1);
                klichki[i] = Console.ReadLine();
            }
            Console.WriteLine("\nВаши питомцы:");
            foreach (var klichka in klichki)
            {
                Console.WriteLine("- {0}", klichka);
            }
        }
        else if (ans == "нет" || ans == "Нет")
        {
            Console.WriteLine("У вас нет питомцев, перейдём к следующему вопросу");
        }
        else
        {
            Console.WriteLine("Вы что-то не то ввели, попробуйте ещё раз");
        }

        Console.WriteLine("\nСколько у вас любимых цветов?");
        byte colors = byte.Parse(Console.ReadLine());
        if (colors > 0)
        {

            string[] color = new string[colors];

            for (int i = 0; i < colors; i++)
            {
                Console.WriteLine("Введите название {0}(ого) любимого цвета", i + 1);
                color[i] = Console.ReadLine();
            }
            Console.WriteLine("\nВаши любимые цвета:");
            foreach (var colorss in color)
            {
                Console.WriteLine("- {0}", colorss);
            }
        }
        else
        {
            Console.WriteLine("Введите положительное число");
        }
    }
    static string getname()
    {
        while (true)
        {
            Console.WriteLine("Введите ваше имя:");
            string inname = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(inname) && !int.TryParse(inname, out _))
            {
                return inname;
            }
            Console.WriteLine("Имя должно состоять из букв, и не быть пустым.");
        }
    }
    static byte getnage()
    {
        while (true)
        {
            Console.Write("Введите возраст: ");
            string input = Console.ReadLine();

            if (byte.TryParse(input, out byte age) && age > 0)
            {
                return age;
            }
            Console.WriteLine("Ошибка, возраст должен быть положительным числом.");
        }
    }
    static string getfirstname()
    {
        while (true)
        {
            Console.WriteLine("Введите вашу фамилию:");
            string infirstname = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(infirstname) && !int.TryParse(infirstname, out _))
            {
                return infirstname;
            }
            Console.WriteLine("Фамилия должна состоять из букв, и не быть пустой.");
        }
    }
    static void end(string name, string firstname, byte age)
    {
        Console.WriteLine("\n");
        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваша фамилия: {0}", firstname);
        Console.WriteLine("Ваш возраст: {0}", age);
    }
}
