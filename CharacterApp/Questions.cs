using System;
using System.Collections.Generic;

namespace CharacterApp
{
    public class Questions
    {
        public Questions(string text, int posScore, int negScore)
        {
            Text = text;
            TrueValue = posScore;
            FalseValue = negScore;
        }

        public string Text { private set; get; }

        public int  TrueValue { private set; get; }

        public int  FalseValue { private set; get; }

        static Questions()
        {
            All = new List<Questions>
            {
                // Part 1. Getting Started with XAML
                new Questions("You care about the environment",
                                      1,-1),
                new Questions("You are a class clown",
                                      -1,1),
                new Questions("You like donuts",
                                      -1,1),
                new Questions("You hate your neighbor",
                                      -1,1),
                new Questions("You love your dog",
                                      1,-1),
                new Questions("You play an instrument",
                                      1,-1),
                new Questions("You like school",
                                      1,-1)
            };
        }

        public static IList<Questions> All { private set; get; }
    }
    
}

