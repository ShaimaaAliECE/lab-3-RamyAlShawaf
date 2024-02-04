using System;
namespace Lab3App
{
    public class MagicWand : Tool
    {
        // Constructor that takes a description parameter
        public MagicWand(string description)
        {
            this.Description = description;
        }

        public override void Display()
        {
            // The base.Display() call was removed to prevent duplication
            Console.WriteLine("MagicWand " + this.Description + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }
    }
}
