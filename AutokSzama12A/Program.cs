using AutokSzama12A.Model;

namespace AutokSzama12A
{
    internal class Program
    {
        public static List<Auto> autok;
        
        
        static void Main(string[] args)
        {

            //1.
            Console.WriteLine("1. lépés: kezdeti állapot:"  );
            Console.WriteLine(Auto.Darabszam);
            Console.WriteLine(Auto.AutokDarabszama());



            //2. objekutmok létrehozása, lista feltöltés objektumokkal
            autok = new List<Auto>(); // lista inicializálás

            Auto auto1 = new Auto("Suzuki", "Swift", "sárga");
            autok.Add(auto1);

            Auto auto2 = new Auto("Ferrari", "F40", "piros");
            autok.Add(auto2);

            Auto auto3 = new Auto("Skoda", "Superb");
            autok.Add(auto3);

            Auto auto4 = new Auto("BYD", "Peti");
            autok.Add(auto4);


            //3A. Objektumok kiiratása
            Console.WriteLine(auto1.ToString());
            Console.WriteLine(auto2.ToString());
            Console.WriteLine(auto3.ToString());
            Console.WriteLine(auto4.ToString());

            //3B. 
            foreach(Auto auto in autok)
            {
                Console.WriteLine(auto.ToString());
            }

            //4A Autókdarabaszáma
            Console.WriteLine(Auto.Darabszam);
            Console.WriteLine(Auto.AutokDarabszama());

            //4B Autókdarabaszáma
            Console.WriteLine(autok.Count);








        }
    }
}
