

using System.Runtime.InteropServices;

namespace Ejemplo2
{
    class Geometry
    {
        public static double CalculateVectorLength2D(double vx, double vy)
        {
            double aux = vx * vx + vy * vy;
            return System.Math.Sqrt(aux);
        }
        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            return CalculateVectorLength2D(vx, vy);
        }

        public static double GetCircleArea(double r)
        {
            double area;
            area = System.Math.PI * r * r;
            return area;
        }
        public static double GetRectangleArea(double height, double with)
        {
            return height * with;
        }


        
       
          


      
        }
   
    }







