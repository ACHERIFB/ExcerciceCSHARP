using System;
using Azerty; // Si dans l'autre classe crée le namespace est Azerty
                // ou l'appeler de cette façn : Azerty.CompteBancaire.Essai()

namespace DemoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //CompteBancaire.Essai();test pour appeler la methode dans une autre classe

            //CompteBancaire cbDeCherif = new CompteBancaire();
            CompteBancaire cbDeCherif = new CompteBancaire(54484);// ajouter un parametre quand on ajoute la methode CompteBancaire avec un parametre : constructeur
            //long n = cbDeCherif.Numero;
            //cbDeCherif.Numero = 5454881425; // on ne peut le declarer que si on mets set a coté de set dans l'autre classe de declaration


            CompteBancaire cbDeAmine = new CompteBancaire(92221, DateTime.Now);

            cbDeAmine.Crediter(222);

            cbDeCherif.Crediter(123);
            
            cbDeCherif.Crediter(456, "Virement Salaire "); // on l'a appeler de la meme façon parce qu'elle fait la meme chose mais elle ajoute une descrption

            Console.WriteLine("solde du compte est{0}",cbDeAmine.Solde);
            Console.WriteLine("solde du compte est{0}, et c'est {1}",cbDeCherif.Solde,cbDeCherif.Description);


            //int cpt = CompteBancaire.Compteur; // appeler le constructeur static Compteur
            int cpt =        //si on avait pas de propriété static pour notre compteur  
            Console.WriteLine("{0} carte(s) crée(s)",cpt );

            Console.ReadKey();




        }
    }
}
