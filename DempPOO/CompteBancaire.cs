// classe
// instace CarteBancaire cbCherif  = new CarteBancaire;
// Accessibilité ( private, public )
// Membre ( proporité , methode :accesseur (set get ...)    )
    
using System;
using System.Collections.Generic;
using System.Text;

namespace Azerty
{
    class CompteBancaire
    {

        /*public static void Essai() // pour que Essai soit visible dans l'autre classe ou dans le main , on est obligé d'ajouter public avant
        {

        }
        */

        /*   private static long _numero; // on le met en privé car il faut pas que puisse le modifié autre part exemple le banquier ne peut pas modifier ton compte bancaire depuis son pc, mais il peut le voir donc uon crée ce qu'il suit:
               public long Getnumero() // creer une methode public qui nous donne accées au numero en lecture
               {
                   return _numero;
               }
                // ou

               public long Numero 
               {
               get { 
                   return _numero;
               }
               set { 
                   // on peut mettre une boucle if par exemple , ne modfier le code que si .................
                   _numero = value;
                   } // on peut le mettre si on veut que notre numero soit modifié


               }
                //Ou

           public long Numeroo { get; }  // { get;set;... }

           // ajouter sur solde par exemple
       */
        private static int _Compteur; // creer un compteur pour avoir le nombre de carte créées, comme on veut pas qu'elle soit public on rajoute un parametre compteur et on laisse le private sur _compteur:
        public static int Compteur 
        {
            get { return _Compteur; }// compteur carte
        }


        private decimal _solde;
        public long Numero { get; }
        public DateTime DateCreation{ get; }
        public decimal Solde { get { return _solde; } }

        public string Description { get; private set; }

        public CompteBancaire (long num)
        {
            Numero = num;
            _Compteur++; //compteur carte
        }
        public CompteBancaire(long num,DateTime dateCréa):this(num) 
        {
            DateCreation = dateCréa;
        }


        public void Crediter (decimal montant) // on a pas utilisé de constructeur car c'est une fonction qui se repete or pour cartebancaite on le crée une fois puis plus jamais d'ou le nom constructeur
        {
            _solde += montant;
        
        }
        public void Crediter(decimal montant ,string description)
        {
            Crediter(montant);
            Description = description;

        }






    }
}
