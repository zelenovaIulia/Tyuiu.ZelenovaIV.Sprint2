using Tyuiu.ZelenovaIV.Sprint2.Task0.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 8105;
        int y = 275;



        Console.Title = "Спринт #2 | Выполнил: Зеленова Ю.В. | АСОиУб-25-1";
        Console.WriteLine("**************************************************************************************");
        Console.WriteLine("* спринт #2                                                                          *");
        Console.WriteLine("* Тема: Базовые навыки работы с C#                                                   *");
        Console.WriteLine("* задание #0                                                                         *");
        Console.WriteLine("* вариант #11                                                                        *");
        Console.WriteLine("* выполнил: Зеленова Юлия Владимировна | АСОиУб-25-1                                 *");
        Console.WriteLine("**************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                           *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) *");
        Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность(массив): (True, False, True, False, True, False), при x = 8105, y = 275. *");
        Console.WriteLine("*                                                                                    *");
        Console.WriteLine("**************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
        Console.WriteLine("**************************************************************************************");
        Console.WriteLine("x = 8105, y = 275                                                                    *");
        Console.WriteLine("**************************************************************************************");

        bool[] res = ds.GetCompareOperations(x, y);

        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine($"res[{i}] = {res[i]}");
        }

        Console.ReadKey();
    }
}