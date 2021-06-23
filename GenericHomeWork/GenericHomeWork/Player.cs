using System;
using System.Collections.Generic;
using System.Text;

namespace GenericHomeWork
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        Random rand = new Random();
        public Card Output()
        {
            return Hand[rand.Next() % Hand.Count];
        }
    }
}
