﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    public abstract class Osoba
    {
        private string imie, nazwisko, pesel;
        public void SetFirstName(string imie) 
        {
            this.imie = imie;
        }
        public void SetLastName(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }
        public void SetPesel(string pesel)
        {
            this.pesel = pesel;
        }
        public int GetAge(DateTime date)
        {
            int dzien = (int)pesel[4] * 10 + (int)pesel[5];
            int miesiac = (int)pesel[2] * 10 + (int)pesel[3];
            int rok;
            if (miesiac < 13)
            {
                rok = 1900 + (int)pesel[0] * 10 + (int)pesel[1];
            }
            else
            {
                rok = 2000 + (int)pesel[0] * 10 + (int)pesel[1];
            }

            int wiek = date.Year - rok;
            if (date.Month > miesiac)
            {
                wiek--;
            }
            else
            {
                if (date.Month == miesiac)
                {
                    if (date.Day > dzien)
                    {
                        wiek--;
                    }
                }
            }
            return wiek;
        }
        public string GetGender()
        {
            return int.Parse(pesel.Substring(9, 1)) % 2 == 0 ? "kobieta" : "mężczyzna";
        }
        public virtual string GetEducationInfo()
        {
            return "";
        }
        public string GetFullName()
        { 
            return imie + " " + nazwisko;
        }
        public virtual bool CanGoAloneToHome()
        {
            return true;
        }
    }
}
