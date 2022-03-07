﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody9_14
{
    class Metody
    {

        public static double KvadratickaRovnice(double a, double b, double c, out double x1, out double x2, out double d)
        {
            d = (b * b) - (4 * a * c);
            x1 = 0;
            x2 = 0;
            if (d < 0)
            {
                d = 0;
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
            }
            return d;
        }



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

        public static int PocetSlov1(string retezec, out string upravenyRetezec)
        {
            int pocetSlov = 0;
            char[] separators = { ' ' };
            retezec = retezec.Trim();
            string[] poleSlov = retezec.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            /*foreach(string s in poleSlov)
            {
                ++pocetSlov;
            }*/
            pocetSlov = poleSlov.Length;


            int i = 0;
            while(i < retezec.Length)
            {
                if (Char.IsNumber(retezec[i]))
                {
                    retezec = retezec.Remove(i, 1);
                }
                else ++i;
            }
            upravenyRetezec = retezec;
            return pocetSlov;
        }

        public static int PocetSlov2(ref string retezec)
        {
            //Druhý způsob (používáme ref)
            //Ref mění původní hodnotu
            int pocetSlov = 0;
            char[] separators = { ' ' };
            retezec = retezec.Trim();
            string[] poleSlov = retezec.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            pocetSlov = poleSlov.Length;

            int i = 0;
            while (i < retezec.Length)
            {
                if (Char.IsNumber(retezec[i]))
                {
                    retezec = retezec.Remove(i, 1);
                }
                else ++i;
            }

            return pocetSlov;
        }

        public static bool ObsahujeSlovo(string retezec, out string nejdelsiSlovo, out string nejkratsiSlovo)
        {
            bool obsahujeSlovo = false;
            string nejdelsiSlovo = " ";
            string nejkratsiSlovo = " ";
            char[] separators = { ' ' };
            string[] poleSlov = retezec.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach(string s in poleSlov)
            {
                if(poleSlov.Length > 0)
                {
                    obsahujeSlovo = true;
                }
            }





            return obsahujeSlovo;
        }
    }
}
