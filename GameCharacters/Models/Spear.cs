using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacters.Models
{
    public class Spear : IHero
    {
        public string Name { get; set; } = "Копейщик";
        public string Weapon { get; set; } = "Копье";

    }
}
