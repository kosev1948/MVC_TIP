using System;

namespace TipMVC.View
{
    internal class Display
    {
        public double Amount { get;  set; }
        public double Percent { get;  set; }
        public double Tip { get; set; }
        public double Total { get; set; }

        public void Input()
        {
            Console.WriteLine( "Enter the amount of the meal: ");
            Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Percent of the tip: ");
            Percent = double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"Your tip is: {Tip:C}");
            Console.WriteLine( "The total will be :{0:C}",Total);
        }
    }
}
