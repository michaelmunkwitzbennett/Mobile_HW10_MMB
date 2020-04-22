using System;
using System.Collections.Generic;

namespace CharacterApp
{
    public class Characters
    {
        public string Name { private set; get; }

        public int MinScore { private set; get; }

        public int MaxScore { private set; get; }

        public string Img { private set; get; }

        public Characters(string name, int minScore, int maxScore, string img)
        {
            Name = name;

            MinScore = minScore;

            MaxScore = maxScore;

            Img = img;
        }

        static Characters()
        {
            All = new List<Characters>
            {
                // Part 1. Getting Started with XAML
                new Characters("Homer",-100,-6,"homer.png"),
                new Characters("Bart",-5,-1,"bart.png"),
                new Characters("Lisa",0,4,"lisa.png"),
                new Characters("Marge",5,100,"marge.png"),
            };
        }

        public static IList<Characters> All { private set; get; }
    }
}
