using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Entity.Entity;

namespace Entity.Abstract
{
    [JsonDerivedType(typeof(Voiture), typeDiscriminator: "voiture")]
    [JsonDerivedType(typeof(Camion), typeDiscriminator: "camion")]
    public abstract class Vehicule
    {
        [JsonInclude]
        private string _marque;

        private string _modele;

        [JsonInclude]
        private int _numero;


        protected Vehicule() { }

        protected Vehicule(string marque, string modele, int numero)
        {
            SetMarque(marque);
            _modele = modele;
            SetNumero(numero);
        }

        public string GetMarque()
        {
            return _marque;
        }

        public void SetMarque(string marque)
        {

            if (Regex.IsMatch(marque, @"[0-9]"))
                throw new Exception("La marque ne peut pas contenir de chiffre.");
            else
                _marque = marque.ToUpper();
        }

        public string Modele
        {
            get { return _modele; }
            set { _modele = value; }
        }

        public int GetNumero()
        {
            return _numero;
        }

        public void SetNumero(int numero)
        {
            if (numero.ToString().Length < 4 || numero.ToString().Length > 6)
                throw new Exception("Le numéro doit contenir entre 4 et 6 chiffres.");
            else
                _numero = numero;
        }

        public override string ToString()
        {
            return $"MARQUE : {_marque} / MODELE : {_modele} / NUMERO : {_numero}";
        }
    }
}
