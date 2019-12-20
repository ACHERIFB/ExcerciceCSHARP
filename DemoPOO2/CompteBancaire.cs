using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPOO
{
    class CompteBancaire
    {
        private static int _compteur;   // Champ statique
        // la valeur d'un champ statique est partagée entre toutes les instances de la classe
        public static int Compteur  // Propriété statique
        {
            get { return _compteur; }
        }
        public long Numéro { get; }
        public DateTime DateCreation { get; }

        public decimal Solde { get; private set; }

        public string Description { get; private set; }

        public Carte CB { get; private set; }

        public void Créditer(decimal montant)
        {
            Solde += montant;
        }
     
        public CompteBancaire(long num)
        {

            
            Numéro = num;
            _compteur++;    // Incrémentation du compteur d'instances (statique)
        }

        public CompteBancaire(long num, DateTime dateCréa, Carte cb) : this(num)
        {
            DateCreation = dateCréa;
            CB = cb;
        }

        public void Créditer(decimal montant, string description)
        {
            Créditer(montant);
            Description = description;
        }
    }
}
