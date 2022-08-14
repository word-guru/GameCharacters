using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacters.Models
{
    public interface IHero
    {
        public string Name { get; set; }
        public string Weapon { get; set; }
    }
}
