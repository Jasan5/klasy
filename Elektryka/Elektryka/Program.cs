using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektryka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Licznik l1 = new Licznik();
            l1.start = 300;
            l1.licznik = l1.start;
            l1.licznik += 500;
            float z1 = l1.Zuzycie();
            Console.WriteLine("Zużycie energii: " + z1);
            Console.ReadKey();
        }
    }

    public class Licznik
    {
        public float start { get; set; }
        public float licznik { get; set; }
        public float Zuzycie()
        {
            return licznik - start;
        }
    }
}
