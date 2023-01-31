using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Case case1 = new Case(1);
            Case case2 = new Case(2);

            PlateauDeJeu plateau1 = new PlateauDeJeu();

            plateau1.AjouterCase(case1);
            plateau1.AjouterCase(case2);

            Console.WriteLine(plateau1.ToString());
            Console.ReadKey();


        }
    }
}
