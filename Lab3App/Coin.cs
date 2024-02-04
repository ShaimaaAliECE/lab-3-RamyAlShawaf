using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class Coin : Treasure
    {
        public int Value { get; set; }

        public Coin(string description, int score, int value) : base()
        {
            this.Description = description;
            this.Score = score;
            this.Value = value;
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + this.Description + " is displayed");
        }

        protected void UpdateTotalValue()
        {
            this.Board.TotalValue += Value;
            Console.WriteLine("Total Value is updated to: " + this.Board.TotalValue);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue(); // Call UpdateTotalValue when adding the Coin
        }
    }
}
