using RPGItemGenerator.ItemGeneration;
using System;

namespace RPGItemGenerator
{
    public partial class Program
    {
        static void Main(string[] args)
        {

            //GenerateListItems.
            Console.WriteLine("Default Item Gen[0] or Discord Behavior[1]?");
            string choice = Console.ReadLine();
            if (choice == "0")
            {
                var itemG = new RunItemGen();
                double RUNAMOUNT = itemG.GetRunAmount();
                itemG.ConsoleItemGeneration(RUNAMOUNT);
            }
            else
            {
                MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
            }
        }   
    }
}