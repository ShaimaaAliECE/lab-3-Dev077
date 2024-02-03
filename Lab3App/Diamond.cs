using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Diamond : Treasure
    {
        private string name;
        private int Score;

        public Diamond(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public override void AddMe(List<Collectable> list)
        {
            Console.WriteLine(name + " collected, Congrats!!!!");
            list.Add(this);
            UpdateTotalScore();
        }

        public override void Display()
        {
            Console.WriteLine("Diamond" + name + " is displayed");
        }

        public override void UpdateTotalScore()
        {
            CollectionBoard.TotalScore += score;
            Console.WriteLine("Total Score is updated to: " + CollectionBoard.TotalScore);
        }
    }
}



