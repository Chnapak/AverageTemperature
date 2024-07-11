namespace AverageTemp
{
    internal class TempApp
    {
        public void Run()
        {
            // Program that is supposed to find min, max, amount of elements and their avarage values.

            // Loop that takes user input until user inputs "exit"
            bool proceed = true;
            List<double> temperatures = new List<double>();

            while (proceed)
            {
                // Translation: "Input temperature: "
                Console.Write("Zadej teplotu: ");
                string input= Console.ReadLine()!;
                
                if (input == "exit")
                {
                    proceed = false;
                    break;
                }

                double value = SafelyConvertToDouble(input);


                // Tempreatures cannot be less than -274° C or 0 K
                if (value < -274)
                {
                    // Translation: Value doesn't make sense
                    Console.WriteLine("NESMYSLNÁ HODNOTA"); ;
                    continue;
                }

                temperatures.Add(value);
            }

            double sum = 0;
            // There are too ways to find the sum:
            // (Comment one of these if you don't want repetition in your code)
            // Manually
            for (int i = 0; i < temperatures.Count; i++)
            {
                sum += temperatures[i];
            }

            // Using List functions
            sum = temperatures.Sum();

            // Outputs
            Console.WriteLine("--------------");
            Console.WriteLine("Max: " + temperatures.Max());
            Console.WriteLine("Min: " + temperatures.Min());
            Console.WriteLine("Amount: " + temperatures.Count());
            Console.WriteLine("Average: " + (sum/temperatures.Count()));
        }
        public double SafelyConvertToDouble(string s)
        {
            if(double.TryParse(s, out double result))
            {
                return result;
            }
            else 
            {
                return double.MinValue;
            }
        }
    }
}
