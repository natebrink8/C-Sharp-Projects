using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interfaces
{
    interface IWalkAway
    {
        // Multiple inheritances of Interfaces can be performed.
        void WalkAway(Player player);
    }
}
