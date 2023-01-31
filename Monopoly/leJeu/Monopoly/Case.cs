using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Case
    {
        private int emplacement;

        public int Emplacement
        {
            get { return emplacement; }
            set { emplacement = value; }
        }

        public Case(int emplacement)
        {
            this.emplacement = emplacement;
        }

        public override string ToString()
        {
            string msg = "la case :" + " " + this.emplacement;
            return msg;
        }
    }
}
