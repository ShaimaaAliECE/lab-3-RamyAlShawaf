using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a collection board
            CollectionBoard board = new CollectionBoard();

            List<Collectable> possibleCollectiable = new List<Collectable>();
            // Three coins 
            possibleCollectiable.Add(new Coin("Nickel", score:20, value:5));
            possibleCollectiable.Add(new Coin("Dime", score:40, value:10));
            possibleCollectiable.Add(new Coin("Toony", score: 50, value: 100));

            // Five Diamonds with descriptions Diamond1, Diamond2, ... etc.
            for (int i = 1;i <= 5; i++)
            {
                possibleCollectiable.Add(new Diamond("Diamond"+ i, score: 100));
            }

            // Replace this incorrect instantiation
            possibleCollectiable.Add(new Axe("OnlyAxe"));

            // With this correct instantiation
            possibleCollectiable.Add(new MagicWand("OnlyMagicWand"));

            // Associate the CollectionBoard object to all the possible Collectiables
            // using a foreach loop
            foreach (Collectable collectable in  possibleCollectiable)
            {
                collectable.Board = board;
            }

            // Create an empty list to start collecting 
            List<Collectable> collected = new List<Collectable>();

            // Collect the items one-by-one in a foreach loop
            foreach (Collectable collectable in possibleCollectiable)
            {
                collectable.AddMe(collected);
                // Invoke DoAction() if the item is a Tool
                if (collectable is Tool tool)
                {
                    tool.DoAction();
                }
            }

            Console.WriteLine("========================================");
            Console.WriteLine("==== All the Collected items ===========");
            Console.WriteLine("========================================");

            // Display all collected items once
            foreach (Collectable collectable in collected)
            {
                collectable.Display();
            }
        }
    }
}
