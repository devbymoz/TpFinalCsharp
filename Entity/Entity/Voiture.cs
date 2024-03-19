using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entity
{
    public class Voiture : Vehicule
    {
        private int _puissance;


        public Voiture() { }

        public Voiture(string marque, string modele, int numero, int puissance) : base (marque, modele, numero)
        {
            _puissance = puissance;
        }

        public int Puissance 
        {
            get { return _puissance; }
            set { _puissance = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $" / PUISSANCE : {_puissance}cv";
        }
    }
}
