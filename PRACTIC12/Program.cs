using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Введите ваше имя:");
        string name = Console.ReadLine();

        Console.WriteLine("Введите вашу фамилию:");
        string surname = Console.ReadLine();

        string[] lines = await ReadFileAsync("sample.txt");

        Console.WriteLine($"Привет, {name} {surname}!");

        Console.WriteLine("Хотите увидеть строки из файла? (Y/N)");
        string choice = Console.ReadLine();

        if (choice.ToUpper() == "Y")
        {
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }

    static async Task<string[]> ReadFileAsync(string fileName)
    {
        string[] lines = await File.ReadAllLinesAsync(fileName);
        return lines;
    }
}
