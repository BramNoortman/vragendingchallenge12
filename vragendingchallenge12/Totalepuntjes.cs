using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vragendingchallenge12
{
    public class Totalepuntjes
    {
            
        private static int totalPoints = 0;
        private static List<int> punten = new List<int>();
        public static int GetTotal()
        {
            return totalPoints;
        }

        public static void AddPoints(int point, int correct)
        {
            totalPoints = totalPoints + correct;
            punten.Add(point);
        }


    }
}