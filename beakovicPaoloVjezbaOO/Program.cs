using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beakovicPaoloVjezbaOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Neboder tower = new Neboder(200, 10);
            tower.setvisina(tower.Getvisina() + 10);
            tower.SetbrojKatova(Convert.ToInt32(tower.GetbrojKatova()+ 1));
            tower.ToString();
            Console.ReadKey();
        }
    }
}
