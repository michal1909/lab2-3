using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public interface IOsoba
    {
        string imie 
        { 
            get; 
            set; 
        }
        string nazwisko 
        { 
            get; 
            set; 
        }
        string ZwrocPelnaNazwe();
    }
}
