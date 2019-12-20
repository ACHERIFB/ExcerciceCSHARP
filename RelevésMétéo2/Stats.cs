using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RelevésMétéo
{
    public class Stats
    {
        private List<ReleveMensuel> _relevés;

        public Stats(List<ReleveMensuel> relevés)
        {
            _relevés = relevés;
        }

        /// <summary>
        /// Relevé contenant la température maximale la plus élevée
        /// </summary>
        public ReleveMensuel ReleveTempMax
        {
            get
            {
                ReleveMensuel relevé = null;
                foreach (var rel in _relevés)
                {
                    if (relevé == null || rel.TempMax > relevé.TempMax)
                        relevé = rel;
                }

                return relevé;
                //return _relevés.OrderBy(r => r.TempMax).Last();
            }
        }

        /// <summary>
        /// Somme des précipitations d'une année
        /// </summary>
        /// <param name="année"></param>
        /// <returns></returns>
        public float GetPrécipitationsAnnée(int année)
        {
            float précip = 0;
            foreach (var rel in _relevés)
            {
                if (rel.Date.Year == année)
                    précip += rel.Précipitations;
            }

            return précip;
            //return _relevés.Where(r => r.Date.Year == année).Sum(r => r.Précipitations);
        }

        /// <summary>
        /// Durée d'ensoleillement moyenne du mois de Juillet sur toutes les années
        /// </summary>
        public float? EnsoleillementMoyenJuillet
        {
            get { return _relevés.Where(r => r.Date.Month == 7).Average(r2 => r2.Ensoleillement); }
        }

        /// <summary>
        /// Nombre de mois dont la T° max a été > à la T° max moyenne de tous les mois
        /// </summary>
        public float NbMoisChauds
        {
            get { return _relevés.Where(r => r.TempMax > _relevés.Average(r2 => r2.TempMax)).Count(); }
        }

        /// <summary>
        /// Précipitations moyennes par année
        /// </summary>
        public Dictionary<int, float> PrécipitationsMoyennesParAnnée
        {
            get
            {
                var dico = new Dictionary<int, float>();

                foreach (var grp in _relevés.GroupBy(r => r.Date.Year))
                {
                    dico.Add(grp.Key, grp.Average(r => r.Précipitations));
                }

                // Autre solution sans regroupement
                //foreach (int an in _relevés.Select(d => d.Date.Year).Distinct())
                //{
                //    dico.Add(an, _relevés.Where(r => r.Date.Year == an).Average(r => r.Précipitations));
                //}

                return dico;
            }
        }

        /// <summary>
        /// Précipitations moyenne, minimale et maximale pour une année donnée
        /// </summary>
        /// <param name="année"></param>
        /// <param name="moy"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void GetPrécipitationsAnnée(int année, out float moy, out float min, out float max)
        {
            // Avec GroupBy, on peut faire plusieurs agrégations simultanément
            // Dans (a, p) : a représente la valeur de regroupement (année), p représente les lignes du groupe
            // On utilise un type anonyme pour récupérer les valeurs d'égrégats dans un seul résultat 
            var stats = _relevés.Where(r => r.Date.Year == année).GroupBy(r => r.Date.Year,
                (a, p) => new
                {
                    Moy = p.Average(r => r.Précipitations),
                    Min = p.Min(r => r.Précipitations),
                    Max = p.Max(r => r.Précipitations)
                }).FirstOrDefault();

            moy = stats.Moy;
            min = stats.Min;
            max = stats.Max;
        }
    }
}
