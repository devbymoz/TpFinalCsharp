using Entity.Entity;

// Création des entités OK
// Création du menu OK
// CRUD


//try
//{
//    Voiture V1 = new Voiture("1Renault", "Twingo", 1430, 4);
//    Console.WriteLine(V1);
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


// Menu principal
var actionUser = true;

while (actionUser)
{
    Console.WriteLine("Quelle action ?");
    Console.WriteLine("1 - Créer un véhicule");
    Console.WriteLine("2 - Voir un véhicule");
    Console.WriteLine("3 - Mettre à jour un véhicule");
    Console.WriteLine("4 - Supprimer un véhicule");
    Console.WriteLine("5 - Trier les véhicules");
    Console.WriteLine("6 - Filtrer les véhicules");
    Console.WriteLine("7 - Sauvegarder les véhicules");

    string? choixUser = Console.ReadLine();

    switch (choixUser)
    {
        case "1":
            Console.WriteLine("Choix 1");
            break;
        case "2":
            Console.WriteLine("Choix 2");
            break;
        case "3":
            Console.WriteLine("Choix 3");
            break;
        case "4":
            Console.WriteLine("Choix 4");
            break;
        case "5":
            Console.WriteLine("Choix 5");
            break;
        case "6":
            Console.WriteLine("Choix 6");
            break;
        case "7":
            Console.WriteLine("Choix 7");
            break;

        default:
            Console.WriteLine("Aucune action ne correspond à cette touche !");
            break;
    }

}