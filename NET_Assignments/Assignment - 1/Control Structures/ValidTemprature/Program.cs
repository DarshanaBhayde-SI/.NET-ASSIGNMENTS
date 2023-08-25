namespace ValidTemprature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int minValue = 20;
            const int maxValue = 130;
            int totalTemperatures = 0;
            double temperatureSum = 0.0;

            Console.WriteLine("Enter temperatures (20 - 130) Fahrenheit. Enter a sentinel value to end.");

            while (true)
            {
                Console.Write("Enter temperature (or sentinel value to end): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "end")
                {
                    break;
                }

                if (int.TryParse(input, out int temperature))
                {
                    if (temperature >= minValue && temperature <= maxValue)
                    {
                        totalTemperatures++;
                        temperatureSum += temperature;
                    }
                    else
                    {
                        Console.WriteLine("Invalid temperature. Temperature must be between 20 and 130.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid temperature or 'end'.");
                }
            }

            if (totalTemperatures > 0)
            {
                double averageTemperature = temperatureSum / totalTemperatures;
                Console.WriteLine($"Number of temperatures entered: {totalTemperatures}");
                Console.WriteLine($"Average temperature: {averageTemperature:F2} Fahrenheit");
            }
            else
            {
                Console.WriteLine("No valid temperatures entered.");
            }
        }
    }
}