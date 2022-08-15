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
            getAttack = new Dictionary<string, string>();

            foreach (var hero in _hero)
            {
                // var type = hero.Name.ToString
                var type = hero.Name;
                switch (type)
                {
                    case "Лучник":
                        getAttack.Add(type, "стреляет из лука");
                        break;

                    case "Пехотинец":
                        getAttack.Add(type, "Наносит удар мечом");
                        break;
                    case "Копейщик":
                        
                        getAttack.Add(type, "Метает копье");
                        break;
                }
            }
            return getAttack;
        }

        public Dictionary<string,string> GetHero()
        {
            getHero = new Dictionary<string, string>();
            foreach (var hero in _hero)
            {
                getHero.Add(hero.Name, hero.Weapon);               
            }
            return getHero;
        }

    }
}
