using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevésMétéo
{
    // Etape 2 de l'exo
    public static class DAL
    {
        public const string CHEMIN_FICHIER = @"..\..\DonnéesMétéoParis.txt";

        public static List<ReleveMensuel> GetRelevésMensuels()
        {
            // Création d'une liste pour stcker les données
            var relevés = new List<ReleveMensuel>();

            // Chargement des lignes du fichier dans un tableau
            string[] lignes = File.ReadAllLines(CHEMIN_FICHIER);

            // Chargement des données dans la liste
            for (int i = 1; i < lignes.Length; i++)
            {
                var rel = new ReleveMensuel(lignes[i]);
                relevés.Add(rel);
            }

            return relevés;
        }
    }
}
