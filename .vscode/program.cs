// See https://aka.ms/new-console-template for more information


Dictionary<int, string> calcOptions = new Dictionary<int, string>
{
    { 1, "Addition"},
    { 2, "Subtraction"},
    { 3, "Multiplication"},
    { 4, "Division"},
};




Console.WriteLine("Hello, What is your name?");
string name = Console.ReadLine() ?? "User";


foreach (var option in calcOptions)
{
    Console.WriteLine(option.Key + ":" + option.Value);
};
