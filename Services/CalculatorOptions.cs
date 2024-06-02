namespace CalculatorConsoleCS.Services
{
    public class CalculatorOptions
    {
        public void ReturnOptions(string name)
        {
            Dictionary<int, string> CalcOptions = new Dictionary<int, string>
                {
                    { 1, "Addition"},
                    { 2, "Subtraction"},
                    { 3, "Multiplication"},
                    { 4, "Division"},
                };

            Console.WriteLine("Hello " + name + ", Here are your Calculator Options!");
            foreach (var option in CalcOptions)
            {
                Console.WriteLine(option.Key + ": " + option.Value);
            }
        }
    }
}