using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetmonop
{
    public class Depart
    {
        private float rapportArret = 0;
        private float rapportPassage = 0;

        public float RapportArret { get => rapportArret; set => rapportArret = value; }
        public float RapportPassage { get => rapportPassage; set => rapportPassage = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}