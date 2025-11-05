using Tyuiu.ZelenovaIV.Sprint2.Task7.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Зеленова Ю. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Зеленова Юлия Владимировна | АСОиУб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет, и печатает результат на экране                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x;
        double y;

        Console.WriteLine("Введите значение x: ");

        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение y: ");

        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");

        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("*  Результат:                                                             *");
        Console.WriteLine("***************************************************************************");
        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка находится вне заштрихованной области");
        }
        Console.ReadKey();
    }
}