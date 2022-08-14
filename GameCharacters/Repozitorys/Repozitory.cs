using GameCharacters.Models;
using GameCharacters.Repozitorys.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacters.Repozitorys
{
    public class Repozitory : IRepozitory
    {
        private readonly IEnumerable<IHero> _hero;
        private Dictionary<string, string> getHero;
        private Dictionary<string, string> getAttack;

        public Repozitory(IEnumerable<IHero> hero)
        {
            _hero = hero;
        }

        public Dictionary<string, string> Attack()
        {         

            foreach (var hero in _hero)
            {
                var type = hero.GetType().ToString();
                switch (type)
                {
                    case "Archer":
                        getAttack.Add(type, "стреляет из лука");
                        break;

                    case "Infantryman":
                        getAttack.Add(type, "Наносит удар копьем");
                        break;
                    case "Spear":
                        getAttack.Add(type, "Метает копье");
                        break;
                }
            }
            return getAttack;
        }

        public Dictionary<string,string> GetHero()
        {
            
            foreach (var hero in _hero)
            {
                getHero.Add(hero.Name, hero.Weapon);               
            }
            return getHero;
        }

    }
}
