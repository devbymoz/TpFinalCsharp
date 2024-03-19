using Entity.Abstract;
using Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Services.SVehicule
{
    public class VehiculeService
    {

        // Création d'un véhicule
        static public Vehicule CreationVehicule()
        {
            Vehicule newVehicule;
            
            string marque;
            do
            {
                Console.WriteLine("Marque (Sans chiffre) ?");
                marque = Console.ReadLine();
            } while (Regex.IsMatch(marque, @"[0-9]"));

            
            Console.WriteLine("Modèle ?");
            string modele = Console.ReadLine();

            int numero;
            do
            {
                Console.WriteLine("Numéro (Entre 4 et 6 chiffres) ?");
                numero = int.Parse(Console.ReadLine());
            } while (numero.ToString().Length < 4 || numero.ToString().Length > 6);


            while (true)
            {
                Console.WriteLine("Quel type ? v pour voiture, c pour camion");
                string typeVehicule = Console.ReadLine().ToLower();

                if (typeVehicule == "v")
                {
                    Console.WriteLine("Puissance");
                    int puissance = int.Parse(Console.ReadLine());

                    try
                    {
                        newVehicule = new Voiture(marque, modele, numero, puissance);

                        Console.WriteLine("Votre voiture a été créé");
                        Console.WriteLine();

                        return newVehicule;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (typeVehicule == "c")
                {
                    Console.WriteLine("Poids");
                    int poids = int.Parse(Console.ReadLine());

                    try
                    {
                        newVehicule = new Camion(marque, modele, numero, poids);

                        Console.WriteLine("Votre camion a été créé");
                        Console.WriteLine();
                        return newVehicule;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }







}
