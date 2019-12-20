using System;

namespace Demo
{
    enum Sexes { Femme, homme }
    class Program
    {
        static void Main(string[] args)
        {
            //Demo1();
            //Demo2();
            //Demo3();


            string message = Demo4("cherif", 1987, "M");
            Console.WriteLine(message);

            Console.ReadKey(); // sans cette ligne demo.exe ne se lance pas correctement quand on clique dessus
        }

        static void Demo1()
        {
            Console.WriteLine("Ecriture");
            Console.WriteLine("des mots ");
            Console.Write("sans sauter de lignes");


            Console.WriteLine("\n le slache N nous permets des sauts de lignes");
            Console.WriteLine("\n comme ceci");

            Console.WriteLine("saisissez votre nom");
            string nom = Console.ReadLine();
            Console.WriteLine("Bonjour " + nom + " Qeulle est votre date de naissance");
            string rep = Console.ReadLine();

            int annéeNaissance = int.Parse(rep);

            int age = 2019 - annéeNaissance;
            Console.WriteLine("vous avez " + age); //age est converti automatiquement en string par C#
            Console.WriteLine("Bonjour{0},vous allez avoir {1}", nom, age);
            Console.WriteLine($"Bonjour{nom},vous allez avoir {age}");

            if (annéeNaissance % 4 == 0) //si  le reste de division de annéeNaissance par 4 ==0 
                Console.WriteLine(" vous etes né durant une année bissextile");
            else
                Console.WriteLine(" vous n'etes pas né durant une année bissextile");

            string message;
            message = (annéeNaissance % 4 == 0) ? "est une année bissextile" : "n'est pas une année bissextile";
            Console.WriteLine(message);

            if (age < 25)
                Console.WriteLine("Vous etes dans la tranche d'age de moins de 25");
            else if (age >= 25 && age < 35)
                Console.WriteLine("vous etes dans la tranche d'age des 25-35");

            else
                Console.WriteLine("vous etes vieux");

            const int annéeMin = 1900;
            const int annéeMax = 2019;
            if (annéeNaissance < annéeMin || annéeNaissance > annéeMax)
                Console.WriteLine("Vous devez saisir une année valide");

        }
        static void Demo2()
        {
            string texte;
            string phrase; // si on veut les mettres dans une seile lignes on mets string texte,phrase;
            int nbPhrases, nbMots;

            phrase = "Le c# est moderne et puissant";
            texte = phrase;
            texte = texte + "il est utilisé dans toutes sortes d'applications\n";
            texte += "-application console";// texte = texte +
            texte += "-application fenetré avec winforms et WPF\n";//texte = texte +
            texte += "-application mobile avec Xamarin\n"; // texte = texte +

            Console.WriteLine(texte);

            char lettre;
            lettre = phrase[3]; //recuperer le caractere n3 de la phrase 0  1  2  3 dont c 3 c'est le C

            int[] tabPos = new int[3];
            tabPos[0] = 3;
            tabPos[1] = 4;
            tabPos[2] = 40;

            tabPos = new int[3] { 3, 4, 40 };
            Console.WriteLine(tabPos.Length); // il nous affiche la taille du tableau donc 3

            for (int i = 0; i < tabPos.Length; i++)
            {
                Console.WriteLine("positiob{0}:{1}", i, tabPos[i]);
            }


            // ou----------------------------------------------
            int j = 0;
            while (j < tabPos.Length)
            {
                Console.WriteLine("positiob{0}:{1}", j, tabPos[j]);
                j++; //pour eviter la boucle infinie car j initié a 0 puis la condition est toujours vrai < tabbPos.length
            }

            // ou-----------------------------------------------
            j = 0;
            do
            {
                Console.WriteLine("positiob{0}:{1}", j, tabPos[j]);
                j++; // on incremente j
            } while (j < tabPos.Length);

            // ou bien ------------------------------------------------

            foreach (int item in tabPos)
            {
                Console.WriteLine("{0}", item);

            }

            nbPhrases = 0;
            for (int i = 0; i < texte.Length; i++)
            {
                if (texte[i] == '\n')
                    nbPhrases++; // on incremente le nombre de phrase
            }
            Console.WriteLine("nous avons {0}phrases dans notre texte", nbPhrases);

        }

        static void Demo3()
        {
            string phrase = "Le c# est moderne et puissant";

            int n = CompterMots(phrase);

            Console.WriteLine(" La phrase {0} contient {1} mots", phrase, n);

        }
        // Fonctions
        static int CompterMots(string p) //le paramettre P recupere la variable "phrase"

        {

            int nbMots = 0;


            // calcul le nombre de Mots donc boucle fort qui parcours la phrase et des qu'il y a un espace ca incremente un compteur.
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == ' ' || p[i] == '\'' || p[i] == '\n') // les apostrophes et les retours a la lignes sont rajoutées au espaces
                {
                    nbMots++;
                }

            }
            return nbMots + 1;// car le nombre d'espace q"on compte est toujour infereir de 1 a celui des mots, hors nous on veut le nbmots
        }

        static string Demo4(string nom, int date, string sexe)
        {
            Console.WriteLine("Bonjour Merci d entrer votre nom");
            nom = Console.ReadLine();
            Console.WriteLine("Merci d entrer votre annee de naissance");
            date = int.Parse(Console.ReadLine());
            int age = 2019 - date;
            Console.WriteLine("Merci d entrer votre sese ( M ou F )");
            sexe = Console.ReadLine();

            string message;

            if (sexe == "M")
            {
                message = ("Bonjour Monsieur " + nom + ", vous avez" + age);

            }
            else if (sexe == "F")
            {

                message = ("Bonjour Madame " + nom + ", vous avez" + age);

            }
            else
            {
                message = "Vous avez une erreur de saisie";
            }

            return message;



        }


    }
}
