using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_Classe_Abstraite
{
    class Camion : Vehicule
    {
        //Attribut privé poids
        private int poids;
        //Constructeur de la classe camion
        public Camion(int p_matricule, string p_marque, string p_modele, int p_prix, int p_poids) 
            : base(p_matricule, p_marque, p_modele, p_prix) 
             {
                this.poids = p_poids;    
             }
        //Surcharge des méthodes Demarrer() et Accelerer()
        public override void Demarrer()
        {
            Console.WriteLine("Le camion démarre.");
        }

        public override void Accelerer()
        {
            Console.WriteLine("Le camion Accélère.");
        }
        
        //Surcharge de la méthode spéciale ToString()
        //public override string ToString()
        //{
        //    return "Camion : " + base.ToString()+ " Poids: "+this.poids;
        //}
    }
    
}
