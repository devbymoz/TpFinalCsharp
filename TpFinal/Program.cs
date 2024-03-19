using Entity.Abstract;
using Entity.Entity;
using Repository.RyVehicule;
using Services.SVehicule;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

// BUG
// Le menu s'affiche deux fois apres avoir créer une véhicule.
// Mettre le systeme de sauvegarde en Async
// Manque marque et numéro dans json


// MENU PRINCIPAL
int actionUtilisateur = 1;
List<Vehicule> listeVehicules = new List<Vehicule>();
RepositoryVehicule repo = new RepositoryVehicule();


while (actionUtilisateur != 0)
{
    Console.WriteLine();
    Console.WriteLine("Quelle action voulez-vous faire ?");
    Console.WriteLine("1 - Créer un véhicule");
    Console.WriteLine("2 - Voir un véhicule");
    Console.WriteLine("3 - Voir tous mes véhicule");
    Console.WriteLine("4 - Mettre à jour un véhicule");
    Console.WriteLine("5 - Supprimer un véhicule");
    Console.WriteLine("6 - Trier les véhicules");
    Console.WriteLine("7 - Filtrer les véhicules");
    Console.WriteLine("8 - Sauvegarder les véhicules");
    Console.WriteLine("0 - Quitter le programme");

    string? choixUtilisateur = Console.ReadLine();

    switch (choixUtilisateur)
    {
        case "1":
            Console.WriteLine("Créer votre véhicule");
            Vehicule newVehicule = VehiculeService.CreationVehicule();
            listeVehicules.Add(newVehicule);
            break;

        case "2":
            Console.WriteLine("Indiquer le numéro du véhicule que vous souhaitez voir");
            int numeroVehicule = int.Parse(Console.ReadLine());

            Vehicule monVehicule = repo.GetVehiculeParNumero(numeroVehicule);
            Console.WriteLine(monVehicule);
            break;

        case "3":
            List<Vehicule> listeMesVehicules = repo.GetAllVehicule();

            foreach (var vehicule in listeMesVehicules)
            {
                Console.WriteLine(vehicule);
            }
            break;

        case "4":
            Console.WriteLine("Choix 3");
            break;

        case "5":
            Console.WriteLine("Choix 4");
            break;

        case "6":
            Console.WriteLine("Choix 5");
            break;

        case "7":
            Console.WriteLine("Choix 6");
            break;

        case "8":
            repo.Sauvegarde(listeVehicules);
            break;

        case "0":
            Console.WriteLine("Aurevoir");
            actionUtilisateur = 0;
            break;

        default:
            Console.WriteLine("Aucune action ne correspond à cette touche !");
            break;
    }
}


