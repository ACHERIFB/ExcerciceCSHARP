/*
using System;

namespace MoisSaisons
{
    [Flags]
    public enum Droits
    {
        Aucun = 0,
        Lecture = 1,
        Création = 2,
        Exécution = 4,
        Modification = 8
    }
    // Création d'un dictionnaire d’utilisateurs avec des droits associés
    var droitsUtilisateurs = new Dictionary<string, Droits>();
    droitsUtilisateurs.Add("Yves", Droits.Aucun);
droitsUtilisateurs.Add("Aline", Droits.Lecture);
droitsUtilisateurs.Add("Marie", Droits.Exécution | Droits.Modification);
droitsUtilisateurs.Add("Eric", Droits.Lecture | Droits.Exécution | Droits.Modification);
droitsUtilisateurs.Add("Denis", Droits.Lecture | Droits.Création | Droits.Exécution |  Droits.Modification);
 
Console.WriteLine("Utilisateurs ayant au moins les droits de lecture et d'exécution : ");

Droits LectureExec = Droits.Lecture | Droits.Exécution;
foreach (var d in droitsUtilisateurs)
{
    if ((d.Value & LectureExec) == LectureExec)
        Console.WriteLine(d.Key); // Affiche Eric et Denis
}

Console.WriteLine("Utilisateurs ayant au moins le droit de lecture ou d'exécution : ");
foreach (var d in droitsUtilisateurs)
{
    if ((d.Value & LectureExec) != 0)
        Console.WriteLine(d.Key); // Affiche Aline, Marie, Eric et Denis
}
 
// Ajout du droit de modification à Aline
droitsUtilisateurs["Aline"] |= Droits.Modification;

// Retrait du droit de modification à Eric
droitsUtilisateurs["Eric"] &= ~Droits.Modification;

    class Program
*/

using System;

namespace MoisSaisons
{
    [Flags]
    enum Mois
    {
        aucun = 0, Janvier = 1, Février = 2, Mars = 4, Avril = 8, Mai = 16,
        Juin = 32, Juillet = 64, Aout = 128, Septembre = 256, Octobre = 512, Novembre = 1024, Decembre = 2048
    }

    [Flags]
    enum Saisons { aucun = 0, Hiver = 1, Printemps = 2, Ete = 4, Automne = 8 }
    class Program
    {
        static void Main(string[] args)
        {
            Mois m = Mois.Juin;
            Saisons sais = SaisonsDumois(m);
            Console.WriteLine("Saison(s) du mois {0} : {1}", m, sais);

            /*for (int i = 1; i < (int)Mois.Decembre; i*=2)
            {
                Saisons sais = SaisonsDumois((Mois)i);
                Console.WriteLine("Saison(s) du mois {0} : {1}", (Mois)i, sais);
            }*/
        }

        public static Saisons SaisonsDumois(Mois m)  //Creer une methode avec le parame
        {
            Mois moisHiver = Mois.Decembre | Mois.Janvier | Mois.Février | Mois.Mars;
            Mois moisPrintemps = Mois.Mars | Mois.Avril | Mois.Mai | Mois.Juin;
            Mois moisEte = Mois.Juin | Mois.Juillet | Mois.Aout | Mois.Septembre;
            Mois moisAutomne = Mois.Septembre | Mois.Octobre | Mois.Novembre | Mois.Decembre;

            Saisons sais = Saisons.aucun;

            if ((m & moisHiver) == m) sais |= Saisons.Hiver; // utiliser le masque 
            if ((m & moisPrintemps) == m) sais |= Saisons.Printemps;
            if ((m & moisEte) == m) sais |= Saisons.Ete;
            if ((m & moisAutomne) == m) sais |= Saisons.Automne;

            return sais;
        }

    }
}