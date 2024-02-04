using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class Collectable : Displayable
    {
        public CollectionBoard Board { get; set; }
        public string Description { get; set; }

        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
        }

        public virtual void Display()
        {
            Console.WriteLine(this.Description);
        }
    }
}
