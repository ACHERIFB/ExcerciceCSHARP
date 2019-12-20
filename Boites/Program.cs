using System;

namespace Boites
{
    class Program
    {
        static void Main(string[] args)
        {
            Boite boite1 = new Boite(5,5,5);  // par default c'est carton
            Boite boite2 = new Boite(5, 5, 5, Matieres.Carton);
            bool identique = boite2.Compare(boite1);
            Etiquette destinataireEtiquette = new Etiquette();


            
    
            Boite boiteEtiquette = new Boite(5, 5, 5, Matieres.Carton);
            boiteEtiquette.Etiqueter("Lenom du destinataire", true);// une methode static est une methode qu'on peut appeler sans avoir besoin de creer l'objet , dans notre cas la methode Etiqueter n'est pas static donc on est obliger de prendrel'objet ( boiteEtiquette ) et faire.Etiqueter

            boiteEtiquette.Etiqueter(destinataireEtiquette); //


            int cpt = Boite.Compteur;

            Console.WriteLine(identique);

        }
    }
}
