using System;
using System.Collections.Generic;
using System.Text;

namespace GenericHomeWork
{
    public class Card
    {
        public Suit Suits { get; set; }
        public TypeOfCard Type { get; set; }
        public static bool operator >=Card a, Card b) 
        {
            return (a.Suits >= b.Suits);
        }
        public static bool operator <=(Card a, Card b)
        {
            return (a.Suits <= b.Suits);
        }
    }
}
