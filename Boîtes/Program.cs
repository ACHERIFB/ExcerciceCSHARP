using System;

namespace Boîtes
{
    class Program
    {
        static void Main(string[] args)
        {
            Boite box1 = new Boite(30, 40, 40);
            Console.WriteLine(box1.Volume); 
            
            Boite box2 = new Boite(30, 40, 40, Matières.Métal);
            
            Boite box3 = new Boite(30, 40, 40, Matières.Carton);

            Boite box4 = new Boite(30, 40, 40, Matières.Carton);

            Boite box5 = new Boite(10, 10, 15);

            if (Boite.ComparerStatic(box2, box3)) //ComparerStatic est une méthode qui est un attribut de la classe Boite.
                Console.WriteLine("Boîtes identiques");
            else
                Console.WriteLine("Boîtes distinctes");

            bool res = box3.Comparer(box4); // Comparer est une méthode qui est un attribut des objets de la classe Boite.
            Console.WriteLine(res);

            Console.WriteLine("Il y a {0} boîtes.", Boite.Compteur);

            // Attribution d'une étiquette par composition (l'étiquette est créée par la méthode liée à la boite):

            box5.Etiqueter("Pierre", true);

            // Attribution d'une étiquette par aggrégation (les étiquettes sont indépendantes de la boîte):

            Boite box6 = new Boite(30, 40, 50, Matières.Plastique);

            Etiquette dest = new Etiquette {Texte = "Pierre", Couleur = Couleurs.Blanc, Format = Formats.L};
            Etiquette frag = new Etiquette {Texte = "FRAGILE", Couleur = Couleurs.Rouge, Format = Formats.S};

            box6.Etiqueter(dest, frag);
        }

        
    }
}
