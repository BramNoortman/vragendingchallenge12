using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vragendingchallenge12
{
    public class Totalepuntjes
    {
            
        private static double totalPoints = 0;
        private static List<string> punten = new List<string>();
        public static double GetTotal()
        {
            return totalPoints;
        }

        public static void AddProduct(string name, double correct)
        {
            totalPoints = totalPoints + correct;
            punten.Add(name);
        }


    }
}