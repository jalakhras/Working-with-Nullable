using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Nullable
{
   public class DiamondSkinDefence : ISpecialDefence
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 1;
        }
    }
}