using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    class Program
    {
        static void VypisMenu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec");
        }

        static void Main(string[] args)
        {
            EvidencePojistencu evidence = new EvidencePojistencu();

            sbyte volba = 0;

            while (volba != 4)
            {
                VypisMenu();

                while (!sbyte.TryParse(Console.ReadLine(), out volba))
                    Console.WriteLine("Neplatná volba");
                
                switch (volba)
                {
                    case 1:
                        evidence.PridejPojistence();
                        break;
                    case 2:
                        evidence.VypisVsechnyPojistence();
                        break;
                    case 3:
                        evidence.NajdiPojistence();
                        break;
                    case 4:
                        Console.WriteLine("Nashledanou!");
                        return;
                }    
            }
        }
    }
}