using System;

namespace DemoPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Carte c1 = new Carte(1111, 456465465);
            c1.CodeSecret = 1234;
            c1.Cryptogramme = 456;
            c1.DateExpiration = new DateTime(2021, 12, 31);
            c1.Renouveler(DateTime.Now); // pour renouveller carte 

            CompteBancaire cb1 = new CompteBancaire(4566542123);



            Carte c2 = new Carte(2222, 56456) { CodeSecret = 456, Cryptogramme = 456 };
            Chequier cherquier1 = new Chequier(2222);

            //MoyenPaiement c2 = new Carte(2222, 56456) { CodeSecret = 456, Cryptogramme = 456 };
            //MoyenPaiement Chequier chequier1 = new Chequier(2222); // le molymorphisme c'est preceder avec le nom de la classe mere
            // son utilité est de pouvoir traiter tout les données du meme type exemple tableau tout les variable sont en int ou var
            //







            DateTime dt = new DateTime(2019, 11, 15);
            CompteBancaire cb2 = new CompteBancaire(9996521, dt, c2);
             
            cb2.Créditer(123);
            cb2.Créditer(456, "virement salaire");
                       
            Console.WriteLine("Solde du compte {0} : {1}", cb2.Numéro, cb2.Solde);
            Console.WriteLine("Dernière opération : {0}", cb2.Description);
            Console.WriteLine("Numéro de la carte associé au compte {0} : {1}", cb2.Numéro, cb2.CB.Numéro); 

            int cpt = CompteBancaire.Compteur;  // Utilisation d'une propriété statique
            Console.WriteLine("{0} comptes bancaires ont été créés", cpt);


            Console.ReadKey();
        }
    }

}
