using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RelevésMeteo
{
    static class Dal
    {
        public const string chemin = @"..\..\..\DonnéesMétéoParis.txt";
        

        public static List<RelevéMensuel> GetRelevéMensuels()
        {
            
            List<RelevéMensuel> liste = new List<RelevéMensuel>();

            if (File.Exists(chemin))
            {
                


                // Create a file to write to.
                string[] textelu = File.ReadAllLines(chemin);
                


                for (int i = 1; i < textelu.Length; i++)
                {

                    RelevéMensuel rmi = new RelevéMensuel(textelu[i]);
                    liste.Add(rmi);

                }



            }
            return liste;

        }

        public static int[] GetTableau()
        {
            int[] tab = new int[] { 1, 2, 3 };
            return tab;
        }

    }
}
