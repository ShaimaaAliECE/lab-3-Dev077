using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Lab3App

{
    internal class MagicWand : Tool
    {
        private string name;
        public MagicWand(string name)
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
            Console.WriteLine("Magicand " + name + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("Magicand is Used");
        }
    }
}


