using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判斷座標位於何處
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] xy =Console.ReadLine().Split(' ');
                int x = int.Parse(xy[0]);
                int y = int.Parse(xy[1]);
                //1st Quadrant(第一象限)
                //2nd Quadrant(第二象限)
                //3rd Quadrant(第三象限)
                //4th Quadrant(第四象限)
                //Origin(原點)x(axisx 軸)或 y-axis(y 軸)。
                if (x == 0 && y == 0) Console.WriteLine("Origin");
                else if (x > 0 && y > 0) Console.WriteLine("1st Quadrant");
                else if (x < 0 && y > 0) Console.WriteLine("2nd Quadrant");
                else if (x < 0 && y < 0) Console.WriteLine("3rd Quadrant");
                else if (x > 0 && y < 0) Console.WriteLine("4th Quadrant");
                else if (x > 0 && y == 0) Console.WriteLine("x-axis");
                else if (x == 0 && y > 0) Console.WriteLine("y-axis");
            }
        }
    }
}
