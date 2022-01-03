using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public class Osoba : IOsoba
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string ZwrocPelnaNazwe()
        {
            return imie + " " + nazwisko;
        }
        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public List<IOsoba> list;
        public void WypiszOsoby()
        {
            foreach (IOsoba osoba in list)
            {
                Console.WriteLine(osoba.ZwrocPelnaNazwe());
            }
        }
        public void PosortujOsobyPoNazwisku()
        {
            list.Sort((o1, o2) => String.CompareOrdinal(o1.nazwisko, o2.nazwisko));
        }
    }
}
