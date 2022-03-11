using System;
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
            nejdelsiSlovo = " ";
            nejkratsiSlovo = retezec;
            char[] separators = { ' ' };
            string[] poleSlov = retezec.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach(string s in poleSlov)
            {
                if(poleSlov.Length > 0)
                {
                    obsahujeSlovo = true;

                    if (s.Length > nejdelsiSlovo.Length) nejdelsiSlovo = s;
                    if (s.Length < nejkratsiSlovo.Length) nejkratsiSlovo = s;
                }
            }

            return obsahujeSlovo;
        }

        public static bool JeAlfanum(string retezec, out int pocetMalych, out int pocetVelkych, out int pocetJinych)
        {
            bool jeAlfanum = false;
            pocetMalych = 0;
            pocetVelkych = 0;
            pocetJinych = 0;

            foreach(char c in retezec)
            {
                if (char.IsLetterOrDigit(c))
                {
                    jeAlfanum = true;
                    if (char.IsUpper(c)) ++pocetVelkych;
                    else if (char.IsLower(c)) ++pocetMalych;

                }
                else
                {
                    jeAlfanum = false;
                    ++pocetJinych; 
                }
            }

            return jeAlfanum;
        }

        public static bool Identicke(string s1, string s2, out int pocetOdlisnosti, out int indexOdlisnosti)
        {
            bool jeIdenticke = false;
            pocetOdlisnosti = 0;
            indexOdlisnosti = -1;
            string pomocny = "";

            if(s2.Length < s1.Length)
            {
                pomocny = s1;
                s1 = s2;
                s2 = pomocny;
            }
            
            
            if(s1 == s2)
            {
                jeIdenticke = true;
            }
            else if(s1.Length == s2.Length)
            {
                for(int i = 0; i < s1.Length; ++i)
                {
                    if(s1[i] != s2[i])
                    {
                        ++pocetOdlisnosti;
                        if (indexOdlisnosti == -1) indexOdlisnosti = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < s1.Length; ++i)
                {
                    if (s1[i] != s2[i])
                    {
                        ++pocetOdlisnosti;

                        if (indexOdlisnosti == -1)
                        {
                            indexOdlisnosti = i;
                        }
                    }

                    
                }

                pocetOdlisnosti += s2.Length - s1.Length;
                if (indexOdlisnosti == -1) indexOdlisnosti = s1.Length;
            }






            return jeIdenticke;
        }
    }
}
