using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_Classe_Abstraite
{
    
      abstract class Vehicule
        {
            //Attributs privés
            private int matricule;
            private string marque;
            private string modele;
            private int prix;
            // Attribut de classe/statique
            public static int nb_vehicules = 0;

            // Propriétés
            public int Matricule
            {
                get { return matricule; }
                set { matricule = value; }
            }

            public string Marque
            {
            get { return marque; }
            set { marque = value; }
            }
            public string Modele
            {
                get { return modele; }
                set { modele = value; }
            }
            public int Prix
            {
                get { return prix; }
                set { prix = value; }
            }

            public static int Nb_vehicules
            {
                get { return nb_vehicules; }
            }
            // Constructeurs 
            public Vehicule()
            {
                nb_vehicules += 1;

            }
            public Vehicule(int p_matricule, string p_marque, string p_modele, int p_prix)
            {
                nb_vehicules+=1;
                this.matricule = p_matricule;
                this.marque = p_marque;
                this.modele = p_modele;
                this.prix = p_prix;
            }

            // Méthodes abstraites 
            abstract public void Demarrer() ;
            abstract public void Accelerer() ;

        //public override string ToString()
        //{
        //    return " Matricule: " + this.matricule + " Marque: "
        //    + this.marque + " Modèle: " + this.modele + " Prix: " + this.prix;
        //}
    }
        
    
}
