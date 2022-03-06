using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody9_14
{
    class Metody
    {





        public static bool ObsahujeCislici(string idk, out int cifSoucet, out int lichCifSoucet, out int sudCifSoucet)
        {
            bool obsahujeCislici = false;
            cifSoucet = 0;
            lichCifSoucet = 0;
            sudCifSoucet = 0;
            for (int i = 0; i < idk.Length; ++i)
            {
                if (Char.IsNumber(idk[i]))
                {
                    obsahujeCislici = true;
                    cifSoucet += int.Parse(idk[i].ToString());

                    if (int.Parse(idk[i].ToString()) % 2 != 0)
                    {
                        lichCifSoucet += int.Parse(idk[i].ToString());
                    }
                    else if (int.Parse(idk[i].ToString()) % 2 == 0)
                    {
                        sudCifSoucet += int.Parse(idk[i].ToString());
                    }
                }
            }

            return obsahujeCislici;
        }
    }
}
