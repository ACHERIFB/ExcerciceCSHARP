using System;
using System.IO;
using System.Text;


namespace RelevésMeteo
{
    class Program
    {
        public static void Main()
        {
            string fichier = @"..\..\..\DonnéesMétéoParis.txt";


            if (File.Exists(fichier))
            {
                Console.OutputEncoding = Encoding.UTF8;
                

                // Create a file to write to.
                string[] textelu = File.ReadAllLines(fichier);
                //Console.WriteLine(textelu[15]);
                //RelevéMensuel rm1 = new RelevéMensuel(textelu[15]);
                //Console.WriteLine(rm1.ToString());
                Console.WriteLine("Mois   | T° min | T° max | Précip (mm) | Ensol (H)");


                for (int i = 1; i < textelu.Length; i++)
                {
                    
                    RelevéMensuel rm1 = new RelevéMensuel(textelu[i]);
                    Console.WriteLine(rm1.ToString()); 

                }
                

              
                 

            }
           



            Console.ReadKey();

        }
    }

   
}
