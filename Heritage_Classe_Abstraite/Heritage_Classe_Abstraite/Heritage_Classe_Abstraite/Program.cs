using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_Classe_Abstraite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancier un objet de la classe Voiture.
            Voiture v = new Voiture(1234,"Toyota","Matrix",10000,"Rouge");
            // Exécuter les méthodes ToString, Demarrer et Accelerer.
            Console.WriteLine(v);
            v.Demarrer();
            v.Accelerer();

            //Instancier un objet de la classe Camion.
            Camion c = new Camion(1212,"Toyota","Yaris",8000,75000);
            // Exécuter les méthodes ToString, Demarrer et Accelerer.
            Console.WriteLine("\n"+c);
            c.Demarrer();
            c.Accelerer();
            //Afficher l'attribut statique nb_vehicule.
            Console.WriteLine("\nLe nombres de véhicules instanciés est  : " + Vehicule.nb_vehicules);
            Console.ReadKey();

        }
    }
}
