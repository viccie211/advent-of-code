// See https://aka.ms/new-console-template for more information

using DayOneStageOne;

var dial = new Dial()
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
    var atZero = dial.Turn(step);
    if (atZero)
    {
        password++;
    }

    Console.WriteLine($"Dial is rotated {step.Direction}{step.Amount} to {dial.Position}. At Zero {atZero}");
}

Console.WriteLine($"Password: {password}");