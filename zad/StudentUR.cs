using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public class StudentUR : Student
    {
        public StudentUR(string imie, string nazwisko, string uczelnia, string kierunek, int rok, int semestr) : base(imie, nazwisko, uczelnia, kierunek, rok, semestr)
        {
        }
        public override string WypiszPelnaNazweIUczelnie()
        {
            return base.WypiszPelnaNazweIUczelnie();
        }
    }
}
