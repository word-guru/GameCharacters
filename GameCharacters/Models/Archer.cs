using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacters.Models
{
    public class Archer : IHero
    {
        public string Name { get; set; } = "Лучник";
        public string Weapon { get; set; } = "Лук";
    }
}
