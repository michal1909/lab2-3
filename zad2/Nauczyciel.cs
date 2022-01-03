using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    public class Nauczyciel : Uczen
    {
        private string tytulNaukowy;
        private Collection<Uczen> podwladniUczniowie;
        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            foreach (Uczen uczen in podwladniUczniowie)
            {
                if (uczen.GetAge(dateToCheck) > 12 || uczen.CanGoAloneToHome())
                {
                    Console.WriteLine(uczen.GetFullName());
                }
            }
        }
    }
}
