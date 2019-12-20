using System;


namespace Capitales
{
    class Program
    {

        static string[] capitales = new string[] {"Tirana", "Berlin","Andorre-La-Vieille",
            "Vienne","Bruxelles"};

        static string[] pays = new string[] {"Albalie", "Allemgne","Andorre",
            "Autriche","Belgique" };
        static void Main(string[] args)

        {
            // Jouer();
            jouer2();
        }
        static void PoserQuestion(int numeroQuestion) // creer une methode avec numero question en parametre

        {



            Console.WriteLine("Quelle est la capitale de {0}", pays[numeroQuestion]);// affecter dans 
            string rep = Console.ReadLine();

            if (rep == capitales[numeroQuestion])
            {
                Console.WriteLine("Bonne réponse !!!");

            }
            else
                Console.WriteLine("Mauvaise réponse !!!");


        }

        static void jouer2()
        {

            Console.Clear();// supprimer tout texte console

            Console.WriteLine("Appuyer sur Echap pour arrêter le jeu");
            ConsoleKeyInfo toucheClavier = Console.ReadKey();// recuperer ce que l'utilisateur a appuyer
            Random rd = new Random(); // methode pour generer un 


            while (toucheClavier.Key != ConsoleKey.Escape) // tant que la touche clavier toujours differente d'echape
            {

                int i = rd.Next(capitales.Length - 1);// suite methode pour generer aleatoire
                PoserQuestion(i); // appeler la fonctions PoserQuestion avec le parametre i
                toucheClavier = Console.ReadKey(); // avant de sortir de la boucle , verifier si il a touché sur la touche echape aprés sa réponse a une question
            }





        }
        static void Jouer()
        {
            /*
                        Console.WriteLine("Qeulles est la capitale de l,espagne ?");
                        string rep = Console.ReadLine();

                        if (rep.ToLower() == "madrid")
                        {
                        Console.WriteLine("Bonne réponse");
                        }
                        else 
                        {
                            Console.WriteLine("Mauvaise réponse !!!");
            */



            //for (int i = 0; i < capitales.Length; i++)
            //{
            //    Console.WriteLine("Quelle est la capitale de {0}", pays[i]);
            //    string rep = Console.ReadLine();

            //    if (rep == capitales[i])
            //        Console.WriteLine("Bonne réponse !!!");
            //    else
            //        Console.WriteLine("Mauvaise réponse !!!");

            //}
            string jouerEncore = "o";

            while (jouerEncore.ToLower() == "o")
            {


                int nbBonneReponse = 0;

                for (int i = capitales.Length - 1; i >= 0; i--)

                {
                    PoserQuestion(i);
                    Console.WriteLine("Quelle est la capitale de {0}", pays[i]);
                    string rep = Console.ReadLine();

                    if (rep == capitales[i])
                    {
                        Console.WriteLine("Bonne réponse !!!");
                        nbBonneReponse++;
                    }
                    else
                        Console.WriteLine("Mauvaise réponse !!!");

                }


                Console.WriteLine("Vous avez eu {0} bonne(s) reponse(s)", nbBonneReponse);



                Console.WriteLine("Si vous voulez rejouer , appuyer sur o");
                jouerEncore = Console.ReadLine();

            }

            Console.WriteLine("Merci d'avoir jouer");
        }
    }
}
