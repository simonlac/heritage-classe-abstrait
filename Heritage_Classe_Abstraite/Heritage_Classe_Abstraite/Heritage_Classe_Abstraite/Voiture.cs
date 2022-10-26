using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_Classe_Abstraite
{
    
    class Voiture : Vehicule
    {
        private string couleur;


        public Voiture(int p_matricule, string p_marque, 
                   string p_modele, int p_prix, string p_couleur) 
            : base(p_matricule, p_marque, p_modele, p_prix) 
        { this.couleur = p_couleur; }

        public override void Demarrer()            //Implémentation de la méthode abstraite Démarrer()
        {
            Console.WriteLine("La voiture démarre.");
        }

        public override void Accelerer()         //Implémentation de la méthode abstraite accélérer()
        {
            Console.WriteLine("La voiture Accélère.");
        }
        // Surcharge de la méthode spéciale ToString()
        //public override string ToString()
        //{
        //    return "Voiture: " + base.ToString()+ " Couleur"+ this.couleur;
        //}
    }
    
}
