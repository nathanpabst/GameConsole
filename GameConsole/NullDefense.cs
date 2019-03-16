using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class NullDefense : ISpecialDefense
    {
        //null object pattern
        public int CalculateDamageReduction(int totalDamage)
        {
            return 0; //no operation / "do nothing" behavior
        }
    }
}
