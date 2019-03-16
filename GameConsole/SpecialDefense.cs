using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* BENEFITS OF USING THE NULL OBJECT PATTERN
 * reduce runtime null ref exceptions
 * reduce repetitive null checking code
*/

/* CONSIDERATIONS WHILE USING THE NULL OBJECT PATTERN
 * all developers need to be aware that the null object pattern is in use
 * all clling client code needs to agree on what "do nothing" behavior is
 * usually not used for error handling
 * can hide exceptions and make fault finding harder.
 */ 
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
