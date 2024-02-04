using System;
namespace Lab3App
{
    public abstract class Tool : Collectable
    {
        // Define DoAction as an abstract method, which must be implemented by subclasses of Tool
        public abstract void DoAction();
    }
}
