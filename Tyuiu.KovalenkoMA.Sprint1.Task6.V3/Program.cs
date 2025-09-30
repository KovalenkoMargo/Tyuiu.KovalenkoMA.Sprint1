using Tyuiu.KovalenkoMA.Sprint1.Task6.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #6                                                             *");
        Console.WriteLine("* Выполнила: Коваленко М. А. | ПИНб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("*вычисляет результат по формуле и печатает результат на экране.           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string a;
        Console.WriteLine("Введите значение:");
        a = Convert.ToString(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.LastLetterWord(a));
        Console.ReadKey();

    }
}