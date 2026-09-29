using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutokSzama12A.Model
{
    internal class Auto
    {

        public string Marka { get; set; }   // Objektum szintű prop.
        public string Tipus { get; set; }  // Objektum szintű prop.
        public string Szin { get; set; }   // Objektum szintű prop.
        public static int Darabszam { get; set; }   // Osztály szintű prop. STATIC

        public Auto(string marka, string tipus)
        {
            Marka = marka;
            Tipus = tipus;
            Szin = "fehér";
            Darabszam++;
        }
        public Auto(string marka, string tipus, string szin)
        {
            Marka = marka;
            Tipus = tipus;
            Szin = szin;
            Darabszam++;
        }


        public Auto()
        {
           
        }

        public override string ToString()
        {
            return $"Az autó márkája: {Marka}, típusa: {Tipus}, szine: {Szin}";
        }


        public static string AutokDarabszama()   // Osztály szintű metódus. STATIC
        {
            return $"Összesen {Darabszam} darab autót hoztunk létre";
        }












    }
}
