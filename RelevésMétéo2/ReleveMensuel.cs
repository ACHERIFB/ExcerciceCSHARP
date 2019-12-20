using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevésMétéo
{
    public class ReleveMensuel
    {
        public DateTime Date { get; private set; }
        public float TempMin { get; private set; }
        public float TempMax { get; private set; }
        public float Précipitations { get; private set; }
        public float? Ensoleillement { get; private set; }

        /// <summary>
        /// Initialise un relevé mensuel à partir de la ligne de fichier passée en paramètre
        /// </summary>
        /// <param name="ligne"></param>
        public ReleveMensuel(string ligne)
        {
            // Méthode la plus simple pour extraire les données
            string[] tabVal = ligne.Split('\t');
            Date = DateTime.Parse(tabVal[0]);
            TempMin = float.Parse(tabVal[1]);
            TempMax = float.Parse(tabVal[2]);
            Précipitations = float.Parse(tabVal[3]);
            // Utilisation d'un type nullable pour la durée d'ensoleillement
            if (float.TryParse(tabVal[4], out float enso)) Ensoleillement = enso;


            // Méthode utilisant les fonctions IndexOf et Substring
            /*
            // récupération du mois
            Date = DateTime.Parse(ligne.Substring(0, 10));

            // recherche des positions des tabulations
            int posTab1 = ligne.IndexOf('\t');
            int posTab2 = ligne.IndexOf('\t', posTab1 + 1);
            int posTab3 = ligne.IndexOf('\t', posTab2 + 1);
            int posTab4 = ligne.IndexOf('\t', posTab3 + 1);

            // Récupéréation des valeurs entre les tabulations
            TempMin = float.Parse(ligne.Substring(posTab1, posTab2 - posTab1));
            TempMax = float.Parse(ligne.Substring(posTab2, posTab3 - posTab2));
            Précipitations = float.Parse(ligne.Substring(posTab3, posTab3 - posTab2));
            Ensoleillement= float.Parse(ligne.Substring(posTab4));
            */
        }

        public override string ToString()
        {
            return string.Format("{0:MM/yyyy} | {1,6:F1} | {2,6:F1} | {3,11:F1} | {4,9:F1}",
                Date, TempMin, TempMax, Précipitations, Ensoleillement);

        }
    }
}
