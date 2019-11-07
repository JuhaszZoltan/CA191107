using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191107
{
    class Program
    {
        static void Main(string[] args)
        {
            #region pre
            //string s = "ez egy karaktersor";
            //Console.WriteLine((char)69);

            //bool valasz = s.StartsWith("e");
            //Console.WriteLine(valasz);

            //s = s.ToLower();
            //s = s.ToUpper();

            //Console.WriteLine(s);

            //Console.WriteLine(s[1]);

            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.Write(s[i] + " ");
            //}

            ////értékadás NEM működik
            ////s[10] = 'A';

            //char[] charTomb = new char[s.Length];
            //for (int i = 0; i < s.Length; i++)
            //{
            //    charTomb[i] = s[i];
            //}

            ////charTomb[5] = '8';

            //string ujString = "";

            //for (int i = 0; i < charTomb.Length; i++)
            //{
            //    if (charTomb[i] != ' ')
            //    {
            //        ujString += (char)((int)charTomb[i] + 32);
            //    }
            //    else ujString += ' ';
            //}

            //Console.WriteLine("\n" + ujString);

            //string masik = ujString.Replace("e", "X");
            //Console.WriteLine(masik);

            //bool vanbenne = masik.Contains("pudding");
            //Console.WriteLine(vanbenne);

            ////hányas indexű karaktertől, hány karaktert
            //string harmadik = masik.Remove(3, 10);
            //Console.WriteLine(harmadik);

            //string xEkNelkul = masik.Replace("X", null);

            //Console.WriteLine(xEkNelkul);

            //string besz = s.Insert(7, "szép ");
            //Console.WriteLine(besz);

            //int index = besz.IndexOf("szép");
            //Console.WriteLine(index);

            //string sub = s.Substring(7);

            //Console.WriteLine(sub);

            //sub = s.Substring(7, 8);
            //Console.WriteLine(sub);

            //string[] tomb = besz.Split(' ', 'E');

            //Console.WriteLine("\n\n");
            //for (int i = 0; i < tomb.Length; i++)
            //{
            //    Console.WriteLine(tomb[i]);
            //}

            //Console.WriteLine("---------");
            ////Console.WriteLine(tomb[2]);

            //Console.WriteLine("ez van ott:"+ tomb[0]+"!");

            //char[] ct = { 'a', 'l', 'm', 'a' };
            //string s = new string(ct);
            //char[] ct2 = s.ToCharArray();

            #endregion

            //string mondat = "\"Szia, hogy vagy?\"";

            //Console.WriteLine(mondat);
            //string[] szavak = mondat.Split(' ');

            //for (int i = 0; i < szavak.Length; i++)
            //{
            //    Console.WriteLine(szavak[i].Trim(',', '?', '!', '.', ':', '\'', '\"'));
            //}


            #region 10. feladat

            //Console.Write("szó: ");
            //string s = Console.ReadLine();

            //string nbs = s[0].ToString().ToUpper() + s.Substring(1);
            //string nbs2 = s.Substring(0, 1).ToUpper() + s.Substring(1);
            //Console.WriteLine(nbs2);



            #endregion

            #region 16. feladat

            Console.Write("szó: ");
            string s = Console.ReadLine().ToLower();

            char[] ct = s.ToCharArray();

            for (int i = 0; i < ct.Length - 1; i++)
            {
                for (int j = i + 1; j < ct.Length; j++)
                {
                    if(ct[i] > ct[j])
                    {
                        char sv = ct[i];
                        ct[i] = ct[j];
                        ct[j] = sv;
                    }
                }
            }

            string rs = new string(ct);

            Console.WriteLine(rs);

            #endregion

            Console.ReadKey();
        }
    }
}