using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KandydatNaStudia[] k = new KandydatNaStudia[3];
            k[0] = new KandydatNaStudia("Kowal", 100, 86, 65);
            k[1] = new KandydatNaStudia("Nowak", 55, 45, 90);
            k[2] = new KandydatNaStudia("Orka", 33, 74, 24);
            foreach (var n in k)
            {
                Console.WriteLine("{0} {1}", n.nazwisko, n.Punkty(n.punktyMatematyka, n.punktyInformatyka, n.punktyJezykObcy));
            }
        }
    }

    struct KandydatNaStudia
    {
        public string nazwisko;
        public int punktyMatematyka, punktyInformatyka, punktyJezykObcy;
        public KandydatNaStudia(string naz, int mat, int inf, int lan)
        {
            nazwisko = naz;
            if (mat < 100 && mat > 0)
                punktyMatematyka = mat;
            else if (mat <= 0)
                punktyMatematyka = 0;
            else
                punktyMatematyka = 100;
            if (inf < 100 && inf > 0)
                punktyInformatyka = mat;
            else if (inf <= 0)
                punktyInformatyka = 0;
            else
                punktyInformatyka = 100;
            if (lan < 100 && lan > 0)
                punktyJezykObcy = mat;
            else if (lan <= 0)
                punktyJezykObcy = 0;
            else
                punktyJezykObcy = 100;
        }
        public float Punkty(int mat, int inf, int lan)
        {
            return 0.6f * mat + 0.5f * inf + 0.2f * lan;
        }
    }
}
