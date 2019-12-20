using System;
using System.Collections.Generic;
using System.Text;

namespace Boîtes
{
    public enum Couleurs
    {
        Blanc,
        Bleu,
        Vert,
        Jaune,
        Orange,
        Rouge,
        Marron
    }

    public enum Matières
    {
        Carton,
        Plastique,
        Bois,
        Métal
    }
    class Boite
    {

        //CHAMPS:

        private Etiquette _etiquetteDest, _etiquetteFragile;

        //PROPRIETES :

        public double Hauteur { get; }
        public double Largeur { get; }
        public double Longueur { get; }

        public static int Compteur {get; private set;}

        public Couleurs Couleur { get; set; }

        public Matières Matière { get; } = Matières.Carton;

        public double Volume
        {
            get { return Hauteur * Largeur * Longueur; }

        }

        public Boite(double hauteur, double largeur, double longueur)
        {
            Hauteur = hauteur;
            Largeur = largeur;
            Longueur = longueur;
            Compteur++;
        }

        public Boite(double hauteur, double largeur, double longueur, Matières matière) : this(hauteur, largeur, longueur)
        {
            Matière = matière;
        }

        public void Etiqueter(string destinataire) 
        {
            _etiquetteDest = new Etiquette(destinataire, Couleurs.Blanc, Formats.L); // on fait un constructeur donc on instancie de cette façon
            
        
        }
        public void Etiqueter(string destinataire, bool fragile)
        {
            Etiqueter(destinataire);
            if (fragile)
            {
                _etiquetteFragile = new Etiquette("FRAGILE", Couleurs.Rouge, Formats.S);                
            }
        }

        public void Etiqueter(Etiquette e1, Etiquette e2)        
        {
            _etiquetteDest = e1;
            _etiquetteFragile = e2;
        }

        public bool Comparer(Boite Boite0)
        {
            if (
                Hauteur == Boite0.Hauteur
                && Largeur == Boite0.Largeur
                && Longueur == Boite0.Longueur
                && Matière == Boite0.Matière
                )
                return true;
            else
                return false;
        }

        //Alternative reposant sur une méthode statique (ne dépendant pas d'une instance de la classe)
        public static bool ComparerStatic(Boite Boite1, Boite Boite2)
        {
            return (
                Boite1.Hauteur == Boite2.Hauteur
                && Boite1.Largeur == Boite2.Largeur
                && Boite1.Longueur == Boite2.Longueur
                && Boite1.Matière == Boite2.Matière
                ); // manière plus propre de définir le return lié à un test
               

        }
    }
}
