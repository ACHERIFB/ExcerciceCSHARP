// utilisation des exceptions

using System;

namespace CreationCompte
{
    class Program
    {
        static void Main(string[] args)
        {
            string utilisateur = " ";
            string motDePasse = " ";


            bool loginOk = false;
            bool mdpOk = false;
            bool compteOk = false;

            while (compteOk == false)
            {
                try
                {
                    Saisir(out utilisateur, out motDePasse);
                    VerifierLogin(utilisateur);
                    VerifierMdp(motDePasse);
                    compteOk = true;
                    Console.WriteLine("Un message vient de vous etre envoyé");



                }
                catch (FormatException e1)
                {
                    Console.WriteLine(e1);
                    //throw;
                }


            }





        }
        static void Saisir(out string rep1, out string rep2)
        {

            Console.WriteLine("Merci d'entrer votre identifiant");
            rep1 = Console.ReadLine();



            Console.WriteLine("Merci d'entrer votre mot de passe");
            rep2 = Console.ReadLine();


        }
        static void VerifierLogin(string nom)
        {
            bool loginOk = false;
            do
            {
                if (nom.Length < 5)
                {
                    throw new FormatException("\nLe login doit comporter au moins 5 caracteres");
                }

            } while (loginOk == true);



        }
        static void VerifierMdp(string mdp)

        {
            bool mdpOk = false;
            do
            {
                int nbCaractere = 0;
                int nbChiffre = 0;
                int nbLetrreMajuscule = 0;
                int nbLetrreMiniscule = 0;
                for (int i = 0; i < mdp.Length; i++)
                {
                    nbCaractere++;
                }
                if (nbCaractere > 6)
                {



                    for (int i = 0; i < mdp.Length - 1; i++)
                    {
                        // le mdp[i] c'est numero ascci du caractere i (dans la table ASCCI )
                        if ((48 <= mdp[i]) && (mdp[i] <= 57))
                        {
                            nbChiffre++;

                        }
                        if ((65 <= mdp[i]) && (mdp[i] <= 90))
                        {
                            nbLetrreMajuscule++;
                        }
                        if ((97 <= mdp[i]) && (mdp[i] <= 122))
                        {
                            nbLetrreMiniscule++;
                        }


                    }
                    if ((nbLetrreMajuscule + nbLetrreMiniscule == 0) || (nbChiffre == 0))
                    {
                        throw new FormatException("\nLe mot de passe  doit comporter au moins une lettre et un chiffre");

                    }
                    else
                        mdpOk = true;


                }
                else

                    throw new FormatException("\nLe mot de passe  doit comporter au moins 6 caracteres caractères, dont au moins une lettre et un chiffre");


            } while (mdpOk == false);


        }


    }
}
