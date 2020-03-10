using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beakovicPaoloVjezbaOO
{
    class Neboder
    {
        double visina;
        int brojKatova;
        string ispis;

        public Neboder(double visina, int brojKatova)
        {
            this.visina = visina;
            this.brojKatova = brojKatova;
        }

        public double Getvisina()
        {
            return visina;
        }

        public double GetbrojKatova()
        {
            return brojKatova;
        }

        public void setvisina(double visina)
        {
            this.visina = visina;
        }

        public void SetbrojKatova(int brojKatova)
        {
            this.brojKatova = brojKatova;
        }

        public override string ToString()
        {
            Console.WriteLine("Visina iznosi" + Getvisina() + "\nBroj katova iznosi" + GetbrojKatova());
            return base.ToString();
        }

    }
}
