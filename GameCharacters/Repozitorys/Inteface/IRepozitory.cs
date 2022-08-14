using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacters.Repozitorys.Inteface
{
    public interface IRepozitory
    {
        Dictionary<string, string> GetHero();
        Dictionary<string, string> Attack();
    }
}
