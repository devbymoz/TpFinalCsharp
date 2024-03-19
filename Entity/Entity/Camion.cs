using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entity
{
    public class Camion : Vehicule
    {
        private int _poids;

        public Camion(string marque, string modele, int numero, int poids) : base(marque, modele, numero)
        {
            _poids = poids;
        }
        public int Poids
        {
            get { return _poids; }
            set { _poids = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $" | POIDS : {_poids}";
        }

    }
}
