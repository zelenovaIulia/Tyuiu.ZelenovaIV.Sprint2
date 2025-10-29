using Tyuiu.ZelenovaIV.Sprint2.Task6.V15.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Зеленова Ю. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #15                                                              *");
        Console.WriteLine("* Выполнил: Зеленова Юлия Владимировна | АСОиУб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет, и печатает результат на экране                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение t: ");

        int t;

        Console.WriteLine("Введите количевство дней");

        t = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");

        Console.WriteLine("* Результат:" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");

        Console.WriteLine(ds.FindDayName(t));
        Console.ReadKey();
    }

}