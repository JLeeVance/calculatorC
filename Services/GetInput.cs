namespace CalculatorConsoleCS.Services
{
    public class GetInput
    {
        public int ReturningOptions()
        {
            int selection = 0;
            do
            {
                Console.WriteLine("Please enter your selection : \n ");
                string entry = Console.ReadLine();
                if (entry == null || int.TryParse(entry, out selection) || selection < 1 || selection > 4)
                {
                    Console.WriteLine("Your selection is invalid, please enter a number (1-4)");
                }
            } while (selection < 1 || selection > 4);

            return selection;
        }
    }
}

