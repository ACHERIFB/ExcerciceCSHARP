using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RelevésMeteo
{
    class RelevéMensuel
    {

        public DateTime Mois { get; set; }
        public float Tmin { get; set; }
        public float Tmax { get; set; }
        public float Precip { get; set; }
        public float Ensol { get; set; }

        public RelevéMensuel(string ligne)
        {
            string[] ligneTableau = ligne.Split('\t');
            Mois =DateTime.Parse(ligneTableau[0]) ;
            Tmin = float.Parse(ligneTableau[1]);
            Tmax = float.Parse(ligneTableau[2]);
            Precip = float.Parse(ligneTableau[3]);
            Ensol = float.Parse(ligneTableau[4]);

            
        }

        public override string ToString()
        {
        return String.Format("{0:dd/yyyy}|{1,8}|{2,8}|{3,8}|{4,8}|",Mois,Tmin,Tmax ,Precip,Ensol);

        }

    }
}
