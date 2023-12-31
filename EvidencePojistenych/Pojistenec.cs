﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    class Pojistenec
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Telefon { get; private set; }
        public int Vek { get; private set; }

        public Pojistenec(string jmeno, string prijmeni, int telefon, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Telefon = telefon;
            Vek = vek;
        }

        public override string ToString()
        {
            return String.Format($"{Jmeno} {Prijmeni}    {Vek}    {Telefon}");
        }
    }
}
