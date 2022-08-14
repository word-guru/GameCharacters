using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacters.Models
{
    public class Infantryman : IHero
    {
        public string Name { get; set; } = "Пехотинец";
        public string Weapon { get; set; } = "Меч";
    }
}
