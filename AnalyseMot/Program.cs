//Etape 1 : 
//•	Dans la fonction Main(), faire saisir un mot à l’utilisateur.On ne fera pas de vérification du mot saisi ; on s’attend à ce qu’il ne comporte que des lettres.
//•	Créer une fonction CompterLettres (vide pour l’instant) qui prend en entrée un mot, et renvoie les nombres de lettres, de voyelles et de consonnes
//•	Afficher le résultat de l’appel de cette fonction sous la forme : « ”livre” comporte 5 lettres, dont 3 consonnes et 2 voyelles »
//Etape 2 : implémenter le corps de la fonction vide créée précédemment et tester.


using System;

namespace AnalyseMot
{
    class Program
    {
        static void Main(string[] args)
        {
            string motutilisateur = Console.ReadLine();

            

            CompterLettres(motutilisateur, out int nombreV, out int nombreC);
            Console.WriteLine("le mot {0} contient {1}  lettres dont {2} consonnes et {3} voyelles", motutilisateur,nombreC+nombreV,nombreC,nombreV );

            
        }

        static void CompterLettres(string mot, out int voyelles, out int consonnes)
        {
            consonnes = 0;
            voyelles = 0;
            for (int i = 0; i < mot.Length; i++)
            {

                if (mot[i] == 'a'
                   || mot[i] == 'e'
                   || mot[i] == 'i'
                   || mot[i] == 'o'
                   || mot[i] == 'u'
                   || mot[i] == 'y'
                    )
                {


                    voyelles++;
                }

                else
                {

                    consonnes++;
                }



            }

           

        }


           
        }

}
