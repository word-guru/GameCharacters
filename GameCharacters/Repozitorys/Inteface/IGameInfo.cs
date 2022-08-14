using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacters.Repozitorys.Inteface
{
    public interface IGameInfo
    {
        void Display();
        void DisplayAttack();
        void SaveFile();
    }
}
