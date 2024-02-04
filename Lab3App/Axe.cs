using System;
namespace Lab3App
{
    public class Axe : Tool
    {
        // Constructor that takes a description parameter
        public Axe(string description)
        {
            this.Description = description;
        }

        public override void Display()
        {
            // The base.Display() call was removed to prevent duplication
            Console.WriteLine("Axe " + this.Description + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }
    }
}
