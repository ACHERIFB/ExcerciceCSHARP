using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicules
{
    class Moto : Vehicule // pour qu'il n'affiche pas d'erreur sur Moto il faut declarer un nouveau constructeur a Vehicule
    {

        public Moto(string nom, Energies energie) : base(nom, 2, energie)
        {
        }

        public override string Description()
        {
            //string s = base.Description();

            ////return ($" Je suis une voiture \r\n {s} ");
            //return "Je suis une voiture "+s ;

            return ($" Je suis une moto \n {base.Description()}");

        }

        public Moto(string nom, int prix) : base(nom, prix)
        {

        }
    }
}
