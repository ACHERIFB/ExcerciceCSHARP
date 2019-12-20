using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

namespace Vehicules
{
    public enum Energies
    {
        Aucune,
        Essence,
        Gazole,
        GPL,
        Electrique
    }
    class Program
    {

        static void Main(string[] args)
        {

            //Vehicule v1 = new Vehicule("vehicule1", 4, Energies.Electrique);

            //Vehicule voit = new Voiture("voiture2",Energies.Essence);

            //Vehicule moto = new Moto("Moto1", Energies.Gazole);

            //Console.WriteLine( v1.Description()); // afficher la description de Virtual mais avant il faut creer l'objet Vehicule
            //Console.WriteLine(voit.Description());  // afficher la description de override mais avant il faut creer l'objet voiture
            //Console.WriteLine(moto.Description());

            Vehicule[] tabVehicule = new Vehicule[2];

            Vehicule voiture1 = new Voiture("Megane", 19000);
            Vehicule moto1 = new Moto("Intruder", 13000);
            Vehicule Voiture2 = new Voiture("Enzo", 380000);
            Vehicule Moto2 = new Moto("YamahaXJR1300", 380000);

            SortedList<string,Vehicule> liste1 = new SortedList<string, Vehicule>();

            liste1.Add(voiture1.Nom, voiture1);
            liste1.Add(moto1.Nom,moto1);
            liste1.Add(Voiture2.Nom,Voiture2);
            liste1.Add(Moto2.Nom,Moto2);

            foreach (var item in liste1)
            {
                Console.WriteLine(liste1);
            }







        }
    }



}


