// See https://aka.ms/new-console-template for more information
using AoC;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

string filePath = @"C:\Users\Ed\Workspace\AoC\AoC\data\day2.txt";  // Specify the file path
try
{

    string fileContent = File.ReadAllText(filePath);  // Read entire file as string
    //Console.WriteLine(fileContent);  

    var lines = File.ReadAllLines(filePath);
    //Console.WriteLine(lines);

    List<List<string>> mainData = new List<List<string>>();
    foreach (var line in lines)
    {
        mainData.Add(line.Split(" ").ToList());
    }

    Console.WriteLine(mainData);

    Day2Problems d2 = new Day2Problems();

    try 
    { 
        d2.Day2Part2(mainData); 
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }

}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

