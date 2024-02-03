using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Axe : Tool
    {
        private string name;

        public Axe(string name)
        {
            this.name = name;
        }

        public override void AddMe(List<Collectable> list)
        {
            Console.WriteLine(name + " collected, Congrats!!!!");
            list.Add(this);
            DoAction();
        }

        public override void Display()
        {
            Console.WriteLine("Axe " + name + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }
    }
}

