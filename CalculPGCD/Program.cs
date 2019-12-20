using System;

namespace CalculPGCD
{
    class Program
    {
        static void Main(string[] args)
        {


            int PGCD;
            int valeur1, valeur2;
            saisir(out valeur1, out valeur2);
              
            while (valeur1 != valeur2)
            {
                if (valeur1 > valeur2)
                {
                    valeur1 = valeur1 - valeur2;
                }
                else
                    valeur2 = valeur2 - valeur1;
            }


            Console.WriteLine("le PGCD est {0}",valeur1);

        }

         

        static void saisir( out int p,out int q)
        {
            Console.WriteLine("Merci d'entrer le p :");
            string rep1 = Console.ReadLine();
            p = int.Parse(rep1);

            Console.WriteLine("Merci d'entrer le q :");
            string rep2 = Console.ReadLine();
            q = int.Parse(rep2);


        }
        
        

    }
}
