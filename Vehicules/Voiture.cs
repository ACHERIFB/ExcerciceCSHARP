using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicules
{
    class Voiture : Vehicule
    {
        public Voiture(string nom, Energies energie) : base(nom, 4, energie)
        {
        }


        public override string Description()
        {
            //string s = base.Description();

            ////return ($" Je suis une voiture \r\n {s} ");
            //return "Je suis une voiture "+s ;

            return ($" Je suis une voiture \n {base.Description()}");


        }

        public Voiture(string nom, int prix):base (nom,prix)
            //
        {
            
        }

    }
}
