using System;
using System.Collections.Generic;

namespace Lab3App
{
    abstract internal class Collectable : Displayable
    {
        public string Description;
        public CollectionBoard Board;
        public abstract void Display();
        public abstract void AddMe(List<Collectable> list);
    }

}
