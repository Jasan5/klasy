using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prostopadloscian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostopadloscian p1 = new Prostopadloscian();
            p1.d = 3;
            p1.s = 4;
            p1.w = 5;
            Console.WriteLine(p1.objetosc());
            Prostopadloscian p2 = new Prostopadloscian();
            p2.d = 5;
            p2.s = 7;
            p2.w = 4;
            p1.porownajObjetosc(p2);
        }
    }

    public class Prostopadloscian
    {
        public float d { get; set; }
        public float s { get; set; }
        public float w { get; set; }
        public float objetosc()
        {
            return d * s * w;
        }
        public void porownajObjetosc(Prostopadloscian p)
        {
            if (this.objetosc() > p.objetosc())
                Console.WriteLine("Prostopadłościan pierwszy ma większą objętość niż drugi");
            else if (this.objetosc() < p.objetosc())
                Console.WriteLine("Prostopadłościan pierwszy ma mniejszą objętość niż drugi");
            else
                Console.WriteLine("Oba prostopadłościany mają jednakową objętość");
        }
    }
}
