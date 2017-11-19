using System;

namespace RPGItemGenerator.ItemGeneration
{
    public partial class RunItemGen
    {
        public double GetRunAmount()
        {
            Console.WriteLine("How many items to generate?");
            double runAmount = 100;
            string generateTimes = Console.ReadLine();
            try
            {
                runAmount = Convert.ToDouble(generateTimes);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
            return runAmount;
        }
    }
}
