using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RelevésMétéo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Etapes 1 et 2 de l'exo
            VisualiserFichier();
            Console.ReadKey();

            // Etape 3 de l'exo
            // Récupération de la liste des relévés et affichage de son contenu
            Console.Clear();
            List<ReleveMensuel> relevés = DAL.GetRelevésMensuels();
            foreach (var r in relevés) Console.WriteLine(r);

            // Etape 4 de l'exo
            Console.WriteLine();
            Stats stats = new Stats(relevés);
            Console.WriteLine("Mois le plus chaud :\n{0}", stats.ReleveTempMax);

            // Etape 5 de l'exo
            float precip = stats.GetPrécipitationsAnnée(2017);
            Console.WriteLine("Somme des précipitations de l'année 2017 : {0} mm", precip);

            Console.WriteLine("Durée d'ensoleillement moyenne du mois de Juillet sur toutes les années : {0:F1} h",
                stats.EnsoleillementMoyenJuillet);

            Console.WriteLine("Nombre de mois dont la T° max a été > à la T° max moyenne de tous les mois: {0}",
                stats.NbMoisChauds);

            foreach (var kvp in stats.PrécipitationsMoyennesParAnnée)
            {
                Console.WriteLine("Précipitations moyennes sur {0} : {1:F1} mm", kvp.Key, kvp.Value);
            }

            float moy, min, max;
            stats.GetPrécipitationsAnnée(2017, out moy, out min, out max);
            Console.WriteLine("Précipitations pour l'année {0} :\nMoyennes : {1:F1}\nMin : {2}\nMax : {3}", 2017, moy, min, max);

            Console.ReadKey();
        }

        // Etape 1 de l'exo
        private static void VisualiserFichier()
        {
            // Chargement des lignes du fichier dans un tableau
            string[] lignes = File.ReadAllLines(@"..\..\DonnéesMétéoParis.txt");

            Console.WriteLine("Mois    | T° min | T° max | Précip (mm) | Ensol (H)");
            Console.WriteLine(new string('-', 52));
            ReleveMensuel rel;
            for (int i = 1; i < lignes.Length; i++)
            {
                // Instanciation d'un relevé mensuel et stockage des infos
                // de la ligne de fichier dans ses propriétés
                rel = new ReleveMensuel(lignes[i]);

                // Affichage de ce relevé à l'écran sous le format souhaité
                Console.WriteLine(rel);
            }
            Console.WriteLine(new string('-', 52));
        }

    }
}
