using System;

namespace TableauPermutation
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tableau = new int[] { 47, 23, 45, 14, -5, -9, 74, 62 };
            AfficherTableau(tableau);

            // Tableau passé par référence
            TrierTableau(tableau);
            AfficherTableau(tableau);

            // Si TrierTableau renvoyait son résultat avec return, il faudrait faire ce qui suit :
            //int[] tab2 = TrierTableau(tableau);
            //AfficherTableau(tab2);
        }

        static void TrierTableau(int[] tab) // puisque on va utiliser tab l'appeler en parametre
        {
            bool permut;
            do 
            {
                permut = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        permut = false;
                        int temp = tab[i]; // creer variable temporaire pour effectuer la rotation
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                        permut = true;
                    }

                }

            }
            while (permut == true);



        }

        static void AfficherTableau(int[] tab)
        {


            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();


        }
    }
}
