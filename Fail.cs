using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace FileSysSim
{
    class Fail
    {
        public string Nimi { get; set; }
        public int Pikkus { get; set; }
        public int Remaining { get; set; }
        public Color Color { get; set; }
        public string Operatsioon { get; set; }
        public bool OnNull { get; set; }

        public Fail(string nimi, int pikkus, string operatsioon, Color color)
        {
            this.Nimi = nimi;
            this.Pikkus = pikkus;
            this.Remaining = pikkus;
            this.Operatsioon = operatsioon;
            this.Color = color;
            this.OnNull = false;
        }

        public Fail()
        {
            this.OnNull = true;
            this.Nimi = null;
            this.Pikkus = -1;
            this.Remaining = -1;
            this.Operatsioon = null;
        }

        public override string ToString()
        {
            if (this.OnNull) return "  []";
            return this.Nimi + " [" + this.Pikkus + ", " + this.Operatsioon + "]";
        }
    }
}
