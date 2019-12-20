using System;
using System.Collections.Generic;
using System.Text;

namespace Boites
{

    enum Couleurs { Blanc, Bleu, Vert, Jaune, Orange, Rouge, Marron }
    enum Matieres { Carton, Plastique, Bois, Métal }



    class Boite
    {
        private double _hauteur = 30;
        private double _longueur = 30;
        private double _largeur = 30;
        private Couleurs _couleur;
        private Matieres _matiere = Matieres.Carton;
        private Etiquette _etiquetteDest;
        private Etiquette _etiquetteFragile;


        public double Hauteur //slipette propfull 2 tab
        {
            get
            {
                return _hauteur;
            }
            set
            {
                // on peut mettre une boucle if par exemple , ne modfier le code que si .................
                _hauteur = value;
            }
        }
        public double Longueur  // en lecture seule sonc pas de set
        {
            get
            {
                return _longueur;
            }


        }
        public double Largeur
        {
            get
            {
                return _largeur;
            }

        }
        public Couleurs CouleurBoite // en lecture et ecriture
        {
            get
            {
                return _couleur;
            }
            set
            {

                _couleur = value;
            }


        }
        public Matieres Matiere
        {
            get
            {
                return _matiere;
            }


        }
        public double Volume
        {
            get
            {

                return _hauteur * _largeur * _longueur;
            }


        }
        private static int _Compteur; // creer un compteur pour avoir le nombre de carte créées, comme on veut pas qu'elle soit public on rajoute un parametre compteur et on laisse le private sur _compteur:
        public static int Compteur{ get; private set; }// Compteur

        public void Etiqueter (string destinataire)
        {
            //Etiquette.bl  = new Etiquette;
            
            _etiquetteDest = new Etiquette { Couleur = Couleurs.Blanc, Format = Formats.L, Texte = destinataire }; // on a utilisé un initialiseur on pouvait utiliser un constructeur dans la classe etiquette

        }
        public void Etiqueter(string desti, bool fragile)
        {
            // Etiqueter(desti);

            if (fragile== true)
            {
                _etiquetteFragile = new Etiquette { Couleur = Couleurs.Rouge, Format = Formats.S, Texte = "FRAGILE" };

            }

            
        }
        // surcharge etape 12
        
        public void Etiqueter(Etiquette e1,Etiquette e2 )
        {

            _etiquetteDest = e1;
            _etiquetteFragile = e2;




        }

        public Boite(double haut, double larg, double longe)
        {
            _hauteur = haut;
            _longueur = longe;
            _largeur = larg;

            Compteur++;// incrementer le compteur
           
        }

        
          public Boite(double haut, double larg, double longe, Matieres mat) : this(haut,larg,longe)
        {
          
            _matiere = mat;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="b1"></param>
        /// <returns></returns>
        public bool Compare(Boite b1) 
        {
            if (b1.Hauteur == Hauteur && b1.Largeur == Largeur && b1.Longueur==Longueur && b1.Matiere == Matiere)
            {
                return true;
            }
            else
                return false; 
        }
     

    }

}



