using GameCharacters.Models;
using GameCharacters.Repozitorys.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacters.Repozitorys
{
    public class GemeInfo : IGameInfo 
    {
        private readonly IRepozitory _repozitory;

        public GemeInfo(IRepozitory repozitory)
        {
            _repozitory = repozitory;
        }

        public void Display()
        {
            foreach (var hero in _repozitory.GetHero())
            {
                Console.WriteLine($"Род войск: {hero.Key} Вооружение: {hero.Value}");
            }
        }

        public void DisplayAttack()
        {
            foreach (var hero in _repozitory.Attack())
            {
                Console.WriteLine(hero.Value);
            }
        }

        public void SaveFile()
        {
            string path = "Game hero.txt";

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                foreach (var hero in _repozitory.GetHero())
                {
                    foreach (var item in _repozitory.Attack()) 
                    {
                        if(hero.Key == item.Key) 
                        sw.WriteLine($"Род войск: {hero.Key} Вооружение: {hero.Value} Атака: {item.Value}");
                    }

                }
            }
        }
    }
}
