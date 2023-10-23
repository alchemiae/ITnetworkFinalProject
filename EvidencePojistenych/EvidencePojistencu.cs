using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    class EvidencePojistencu
    {
        Dictionary<string, Pojistenec> evidence = new Dictionary<string, Pojistenec>();

        public void VypisVsechnyPojistence()
        {
            Console.WriteLine("Seznam pojištěnců:");
            foreach (Pojistenec pojistenec in evidence.Values)
            {
                Console.WriteLine(pojistenec);
            }
            Console.WriteLine("\nPokračujte libovolnou klávesou...");
            Console.ReadKey();
        }

        public void NajdiPojistence()
        {
            Console.WriteLine("Zadejte křestní jméno hledaného pojištěnce:");
                string hledaneJmeno = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Zadejte příjmení hledaného pojištěnce:");
                string hledanePrijmeni = Console.ReadLine().ToLower().Trim();
            string klic = hledaneJmeno + " " + hledanePrijmeni.ToLower();

            if (evidence.ContainsKey(klic))
            {
                Console.WriteLine(evidence[klic]);
            }
            else
            {
                Console.WriteLine("Pojištěnec nebyl nalezen.");
            }

            Console.WriteLine("\nPokračujte libovolnou klávesou...");
            Console.ReadKey();
        }

        public void PridejPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = "";
            while (jmeno.Length < 3)// podminit
                jmeno = Console.ReadLine().Trim();
            Console.WriteLine("Zadejte příjmení pojištěného:");
            string prijmeni = "";
            while (prijmeni.Length < 2)
                prijmeni = Console.ReadLine().Trim();
            Console.WriteLine("Zadejte telefonní číslo:");
                int telefon;
                while (!int.TryParse(Console.ReadLine(), out telefon))
                {
                    Console.WriteLine("Neplatné telefonní číslo.");
                }
            Console.WriteLine("Zadejte věk:");
                int vek;
                while (!int.TryParse(Console.ReadLine(), out vek))
                {
                    Console.WriteLine("Neplatný věk.");
                }

            string klic = jmeno.ToLower() + " " + prijmeni.ToLower();
            evidence[klic] = new Pojistenec(jmeno, prijmeni, telefon, vek);

            Console.WriteLine("\nData byla uložena. Pokračujte libovolnou klávesou...");
            Console.ReadKey();
        }
    }
}
