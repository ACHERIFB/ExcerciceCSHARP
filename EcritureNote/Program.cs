// using 

using System;
using System.IO;

namespace EcritureNote
{
    class Program
    {
        static void Main(string[] args)
        {
            SaisirNote();

        }

        static void SaisirNote()
        {



            try
            {
                Console.WriteLine("Merci de saisir un texte");
                string texte = Console.ReadLine();
                Console.WriteLine("Merci de saisir un chemin de texte");
                string cheminFichier = Console.ReadLine();
                EnregistrerNote(texte, cheminFichier);
            }
            catch (DirectoryNotFoundException)
            {

                Console.WriteLine("Le chemin n'existe pas ");
            }
            catch (UnauthorizedAccessException)
            {

                Console.WriteLine("l'acces au fichier a été refusé");
            }

            Console.ReadKey(true);




        }
        static void EnregistrerNote(string txt, string cF)

        {

            using (StreamWriter outputFile = new StreamWriter(cF, true)) // la methode dispose , streamwriter 
            {
                outputFile.WriteLine(txt);
            }




        }



    }
}

/*
 * using System;
using System.IO;

namespace EcrireFichier
{
    class Program
    {
        static void Main(string[] args)
        {

            SaisirNote();
            /*
            try
            {
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
        //}

        //Definir les Fonctions
      /*  static void SaisirNote()
{
    string textNote;
    string cheminFichier;
    Console.WriteLine("saisissez votre test : ");
    textNote = Console.ReadLine();
    Console.WriteLine("saissiez le chemin du fichier dans lequel vvous voulez sauvgarder votre text : ");
    cheminFichier = Console.ReadLine();
    try
    {
        EnregistrerNote(textNote, cheminFichier);
    }
    catch (DirectoryNotFoundException)
    {
        Console.WriteLine("Le Fichier est introuvable");
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("Vous avez pas le droit d'ecriture dans ce ficher");
    }

}

static void EnregistrerNote(string note, string chemin)
{
    /*
    StreamWriter fichierSortie = null;
    try
    {
        fichierSortie = new StreamWriter(chemin, true);
        fichierSortie.WriteLine(note);
    }
    finally
    {
        if (fichierSortie != null)
        {
            fichierSortie.Close();
        }
    }*/
   /* using (StreamWriter fichierSortie = new StreamWriter(chemin, true))
    {
        fichierSortie.WriteLine(note);
    }
}

        /////
    }
}
*/
