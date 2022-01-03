using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public interface IStudent : IOsoba
    {
        string uczelnia
        {
            get;
            set;
        }
        string kierunek
        {
            get;
            set;
        }
        int rok
        {
            get;
            set;
        }
        int semestr
        {
            get;
            set;
        }
    }
}
