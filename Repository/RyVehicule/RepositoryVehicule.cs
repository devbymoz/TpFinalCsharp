using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Repository.RyVehicule
{
    public class RepositoryVehicule
    {
        public RepositoryVehicule() { }

        private string _fichier;

        public string GetFichier => "SauvegardeVehicule/MesVehicules.json";


        /// <summary>
        /// Permet de sauvegarder une liste de véhicule en Json
        /// </summary>
        /// <param name="vehicule">Liste de Vehicule</param>
        public void Sauvegarde(List<Vehicule> vehicule)
        {
            string nomFichier = GetFichier;

            if (vehicule.Count == 0)
            {
                Console.WriteLine("Vous n'avez rien à sauvegarder");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Vous souhaitez sauvegarder vos véhicules");

                string jsonString = JsonSerializer.Serialize<List<Vehicule>>(vehicule);
                File.AppendAllText(nomFichier, jsonString);
                Console.WriteLine("Vos véhicules ont bien été sauvegardés");
            }
        }


        /// <summary>
        /// Permet de récuperer un vehicule grace à son numéro
        /// </summary>
        /// <param name="numero">Vehicule</param>
        /// <returns>Vehicule</returns>
        public Vehicule GetVehiculeParNumero(int numero)
        {
            string nomFichier = GetFichier;

            string contenuFichier = File.ReadAllText(nomFichier);
            List<Vehicule> listeVehicules = JsonSerializer.Deserialize<List<Vehicule>>(contenuFichier);

            try
            {
                Vehicule monVehicule = listeVehicules.Where(p => p.GetNumero() == numero).First();
                return monVehicule;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Aucun numéro ne correspond à ce vehicule");
            }

            return null;
        }

        
        /// <summary>
        /// Permet de récuperer la liste de tous les véhicules
        /// </summary>
        /// <returns>Liste de Vehicule</returns>
        public List<Vehicule> GetAllVehicule()
        {
            string nomFichier = GetFichier;

            string contenuFichier = File.ReadAllText(nomFichier);
            List<Vehicule> listeMesVehicules = JsonSerializer.Deserialize<List<Vehicule>>(contenuFichier);

            if (listeMesVehicules.Count == 0)
            {
                Console.WriteLine("Vous n'avez aucun véhicule");
                return null;
            }

            Console.WriteLine("Voici la liste de vos véhicules :");
            return listeMesVehicules;
        }
    }
}
