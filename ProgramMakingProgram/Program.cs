Console.Title = "Program-Making Program";


var units = Prompt("units");
var type = Prompt("type");

Console.WriteLine($"""

    {GetProgramText(units, type)}

    """);

string Prompt(string text)
{
    var result = "";
    while(string.IsNullOrWhiteSpace(result))
    {
        Console.Write($"Enter the {text} used for the program: ");
        result = Console.ReadLine();
    }
    return result;
}

static string GetProgramText(string units, string type) => $$"""
        Console.WriteLine("Enter the width (in {{units}}) of the triangle: ");
        {{type}} width = {{type}}.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height (in {{units}}) of the triangle: ");
        {{type}} height = {{type}}.Parse(Console.ReadLine());
        {{type}} result = width * height / 2;
        Console.WriteLine($"{result} square {{units}}");
        """;