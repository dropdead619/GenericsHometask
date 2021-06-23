using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericHomeWork
{
    public class Game
    {
        // 1.	Класс Game формирует и обеспечивает: 
        //  a.Список игроков(минимум 2);
        public List<Player> players { get; set; }

        //  b.Колоду карт(36 карт);
        public List<Card> Cards { get; set; }

        //  c.Перетасовку карт(случайным образом);
        Random rand = new Random();
        public void Shuffle()
        {            
            for (int i = 0; i < rand.Next() % 180 + 20; i++)
            {
                int numOfTmp = rand.Next() % Cards.Count;
                Card tmp;
                tmp = Cards[i];
                Cards[i] = Cards[numOfTmp];
                Cards[numOfTmp] = tmp;
            }
        }

        //  d.Раздачу карт игрокам(равными частями каждому игроку);
        public void Distrib()
        {            
            for (int  i =0; i< 3; i++)
            {
                players[i].Hand.Add(Cards.ElementAt<Card>(rand.Next() % Cards.Count));                
            }
        }

        //  e.Игровой процесс.Принцип: Игроки кладут по одной карте.
        //  У кого карта больше, то тот игрок забирает все карты и кладет их в конец своей колоды.
        //  Упрощение: при совпадении карт забирает первый игрок, шестерка не забирает туза. 
        //  Выигрывает игрок, который забрал все карты.
        public void Start()
        {
            while (players[0].Hand.Count==36 || players[1].Hand.Count == 36)
            {
                if (players[0].Output() >= players[1].Output())
                {
                    players[0].Hand.Add(players[1].Output());
                    players[1].Hand.Remove(players[1].Output());
                }
                if (players[1].Output() >= players[0].Output())
                {
                    players[1].Hand.Add(players[0].Output());
                    players[0].Hand.Remove(players[0].Output());
                }
            }
        }
    }
}
