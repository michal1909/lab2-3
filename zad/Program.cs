using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Osoba> osoba = new List<Osoba>();
            Osoba o1 = new Osoba("Kacper", "Kucharski");
            Osoba o2 = new Osoba("Justyna", "Kwiatkowska");
            Osoba o3 = new Osoba("Dagmara", "Sokołowska");
            osoba.Add(o1);
            osoba.Add(o2);
            osoba.Add(o3);
        }
    }
}
