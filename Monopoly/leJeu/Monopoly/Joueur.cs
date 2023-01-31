using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Joueur
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        private float portefeuille;

        public float Portefeuille
        {
            get { return portefeuille; }
            set { portefeuille = value; }
        }

        private Case maCase;

        public Joueur(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
    }
}
