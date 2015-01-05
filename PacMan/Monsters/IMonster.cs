using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.Monsters
{
    interface IMonster
    {
        void Runaway();
        void Follow();
        void Panic();
    }
}
