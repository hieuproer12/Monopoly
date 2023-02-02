using Monopoly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetmonop
{
    public class Ville
    {
        private float prixAchat = 0;
        private float prixNuitee = 0;
        private string nom = "";
        private Joueur proprietaire;

        public float PrixAchat { get => prixAchat; set => prixAchat = value; }
        public float PrixNuitee { get => prixNuitee; set => prixNuitee = value; }
        public string Nom { get => nom; set => nom = value; }
        public Joueur Proprietaire { get => proprietaire; set => proprietaire = value; }

        public Ville(int emplacement, float prixAchat, float prixNuitee, string nom, string libre)
        {
            this.prixAchat = prixAchat;
            this.prixNuitee = prixNuitee;
            this.nom = nom;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

