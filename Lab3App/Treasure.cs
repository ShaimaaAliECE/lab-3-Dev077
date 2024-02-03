using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal abstract class Treasure : Collectable
    {
        public int score;
        public abstract void UpdateTotalScore();
        public abstract override void AddMe(List<Collectable> list);
        public abstract override void Display();

    }
}