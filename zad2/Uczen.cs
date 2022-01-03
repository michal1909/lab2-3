using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    public class Uczen : Osoba
    {
        private string szkola;
        private bool mozeSamWracacDoDomu;
        public void SetSchool(string szkola)
        {
            this.szkola = szkola;
        }
        public void ChangeSchool(string szkola)
        {
            SetSchool(szkola);
        }
        public void SetCanGoAloneHome(bool mozeSamWracacDoDomu)
        {
            this.mozeSamWracacDoDomu = mozeSamWracacDoDomu;
        }
        public override string GetEducationInfo()
        {
            return szkola;
        }
        public override bool CanGoAloneToHome()
        {
            return mozeSamWracacDoDomu;
        }
    }
}
