using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Challenges
{
    public class Exercise1
    {
        public Exercise1()
        {
            int x1, y1;
            int x2, y2;
            int x3, y3;

            x1 = -4;
            y1 = 6;

            x2 = 8;
            y2 = 5;

            x3 = 2;
            y3 = -7;
            
            double avgDistance = GetDistanceAvg(x1, y1, x2, y2, x3, y3);

            Console.WriteLine("Distance Average: {0}", avgDistance);
        }


        private double GetDistanceAvg(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            double distance1 = GetDistance(x1, y1, x2, y2);
            double distance2 = GetDistance(x2, y2, x3, y3);
            double distance3 = GetDistance(x3, y3, x1, y1);
            return (distance1 + distance2 + distance3) / 3.0;
        }
        
        private double GetDistance(int x1, int y1, int x2, int y2)
        {
            double side1 = Math.Pow((x2 - x1), 2);            
            double side2 = Math.Pow((y2 - y1), 2);            
            double distance = Math.Sqrt(side1 + side2);
            Console.WriteLine("Distance: {0}", distance);
            return distance;
        }

    }
}
