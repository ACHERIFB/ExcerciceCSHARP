using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace Vehicules
{
    class Vehicule : IComparable<Vehicule>
    {
        public String Nom { get; }
        public int Nbroues { get; }

        public Energies Energie { get; }
        public int Prix { get; }

        public Vehicule(string nom, Energies energie) // Constructeur vide pour Moto
        {

        }

        public Vehicule(string nom, int nbRoues, Energies energie)
        {
            Nom = nom;
            Nbroues = nbRoues;
            Energie = energie;

        }
        public Vehicule(string nom, int prix)
        {
            Nom = nom;
            Prix = prix;

        }

        public virtual string Description()
        {
            return ($"le vehicule est {Nom} ,roule sur {Nbroues} ,et à l'energie {Energie} ");
        }

        public int CompareTo([AllowNull] Vehicule other)
        {

            if (Prix < other.Prix)
                return -1;

            if (Prix > other.Prix)
                return +1;

            // if (Prix == other.Prix) // impossible d'enlever ce if car obligé de retourner quelque chose
            return 0;

            //
            //return Prix.CompareTo(other.Prix);


        }
        

    }
}
