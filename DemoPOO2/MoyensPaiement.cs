using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPOO
{
    class MoyenPaiement
    {
        public long NuméroCompte { get; }
        public string NomTitulaire { get; set; }
        public string PrénomTitulaire { get; set; }
        public DateTime DateDernierRenouvellement { get; set; }

        public MoyenPaiement(long numéroCompte) // on crée un constructeur de moyen de paiement
        {
            NuméroCompte = numéroCompte;
        }

        public  virtual void Renouveler(DateTime date) // cette methode peut etre redefinie dans les classes fille
        {
            DateDernierRenouvellement = date;
        }

        public override string ToString()  // la methode qui herite de l'objet ( par default )
        {
            return $"Moyen de paimenent est {NuméroCompte} de {NomTitulaire}";
        }



    }
    class Carte:MoyenPaiement  // heritage : carte herite de moyen de paiement
    {
        public int Numéro { get; }
        public DateTime DateExpiration { get; set; }
        public int CodeSecret { get; set; }
        public int Cryptogramme { get; set; }

        public Carte(long numCompte, int numCarte) : base(numCompte) // puisque on a crée un constructeur de moyen de paiement avec un parametre numCompte ,on est obligé de l'appeler sur les constructeur des classes fille 
        {
            Numéro = numCarte;
        }
        public override void Renouveler(DateTime date) //redefinition
        {
            base.Renouveler(date);
            DateDernierRenouvellement = DateExpiration.AddYears(2);
        }

        public override string ToString()
        {
            /*string s = base.ToString();
            s += $"Carte N° {Numéro}";
            return s;*/

            // appelle la méthode ToString de la classe de base et concatène le 
            // résultat avec le numéro de la carte
            return base.ToString() + $"\nCarte N° {Numéro}";
        }
    }

    class Chequier:MoyenPaiement
    {
        public string Adresse { get; set; }
        public long NuméroPremierCheque { get; set; }
        public int NbCheques { get; set; }
        public Chequier(long numCompte) :base (numCompte) //// puisque on a crée un constructeur de moyen de paiement avec un parametre numCompte ,on est obligé de l'appeler sur les constructeur des classes fille 
        {

        }
        public override void Renouveler(DateTime date) //redefinition
        {
            base.Renouveler(date);
            NuméroPremierCheque += NbCheques; //on incremente par nb cheque 
        }
    }
}
