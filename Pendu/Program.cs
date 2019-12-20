using System;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jouez au pendu!");

            //--------------------------------------------------------------------------
            // 1. Les étapes ci-desous consistent à faire saisir un mot valide au 1er joueur

            string mot = string.Empty;
            bool motValide = false;
            // Tant que le mot saisi n'est pas valide
            while (!motValide)
            {
               // On fait saisir le mot
               mot = Console.ReadLine().ToLower();

                // On vérifie son format (appeler la méthode statique VerifierMot)
                try
                {
                    
                    Console.WriteLine(Jeu.VerifierMot(mot));

                }
                catch (FormatException e1)
                {

                    Console.WriteLine(e1.Message);  
                }

            }

            //--------------------------------------------------------------------------
            // 2. les étapes suivantes consistent à faire deviner le mot au 2d joueur

            // On vide l'écran
            Console.Clear();

            // On crée un jeu et on l'initialise avec le mot saisi
            Jeu jeu = new Jeu();
            jeu.InitialiserJeu(mot);

            // Tant que le jeu n'est pas fini
            while (jeu.GetEtatPartie() == EtatsPartie.EnCours)
            {
                // On affiche le dessin et l'état du mot en cours

                // On demande une lettre et on la teste

                // Si la partie est gagnée, on affiche un message en vert
                // Si elle est perdue on affiche un message en rouge avec la solution

            }

            Console.ReadKey();
        }
    }
}
