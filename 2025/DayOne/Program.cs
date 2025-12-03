// See https://aka.ms/new-console-template for more information

using DayOne;

var dial = new DialStageTwo()
{
    Max = 99,
    Min = 0,
    Position = 50,
};
var inputParser = new InputParser();
var inputText = await File.ReadAllTextAsync("./input.txt");
var steps = inputParser.ParseInput(inputText);
int password = 0;
Console.WriteLine($"Dial starts at:{dial.Position}");
foreach (var step in steps)
{
    var result = dial.Turn(step);
    password += result;

    Console.WriteLine($"Dial is rotated {step.Direction}{step.Amount} to {dial.Position}. Passed 0:{result} times");
}

Console.WriteLine($"Password: {password}");