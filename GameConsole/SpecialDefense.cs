using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    //refactoring from an interface to a base class
    public abstract class SpecialDefense
    {
        public abstract int CalculateDamageReduction(int totalDamage);

        public static SpecialDefense Null { get; } = new NullDefense();

        private class NullDefense : SpecialDefense
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                return 0; //no operation / "do nothing" behavior
            }
        }
    }
}
