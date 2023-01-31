using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class PlateauDeJeu
    {
        private List<Case> mesCases;

        public List<Case> MesCases
        {
            get { return mesCases; }
            set { mesCases = value; }
        }
        public PlateauDeJeu()
        {
            mesCases = new List<Case>();
        }
        public void AjouterCase(Case uneCase) => mesCases.Add(uneCase);

        public override string ToString()
        {
            string msg = "";
            foreach (Case unCase in mesCases)
            {
                msg += unCase.ToString() + ", " + "\n";
            }
            return msg;
        }            
    }
}
