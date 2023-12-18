using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_ВМ_лаба4
{
    internal class AillerMethod
    {
        private int _a;
        private int _b;

        public AillerMethod(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public void CalcWithH()
        {
            double h = 0.1;
            Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}  {4,10}  {5,10}{6,10}  {7,10}{8,10}", 
                "x", "y", "f(x,y)", "x+h", "y+h*f", "f(x+h,y+h*f)", "dely", "y-точное", "E");
            double x = 0;
            double y = 0.2;
            double f_x_y = 0;
            double dely=0;
            double toch_y = 0;
            double error = 0;
            double xh = 0;
            double yhf = 0;
            double fh = 0;

            for (int i = 0; i <= 10; i++)
            {
                y = y + dely;
                x = i * h;
                xh = x + h;
                f_x_y = CalcF_X_Y(x,y);
                yhf = y + h * f_x_y;
                fh = CalcF_X_Y(xh, yhf);
                dely = (h/2)*(f_x_y+fh);
                toch_y = F(x);
                error = Math.Abs(toch_y - y);
                Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}  {4,10}  {5,10}  {6,10}  {7,10}  {8,10}",
                Math.Round(x,5), Math.Round(y, 5), Math.Round(f_x_y, 5), Math.Round(xh, 5),
                Math.Round(yhf, 5), Math.Round(fh, 5), Math.Round(dely, 5), Math.Round(toch_y, 5), Math.Round(error, 5));
            }
        }

        public void CalcWithHDiv2()
        {
            double h = 0.05;
            Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}  {4,10}  {5,10}{6,10}  {7,10}{8,10}",
                "x", "y", "f(x,y)", "x+h", "y+h*f", "f(x+h,y+h*f)", "dely", "y-точное", "E");
            double x = 0;
            double y = 0.2;
            double f_x_y = 0;
            double dely = 0;
            double toch_y = 0;
            double error = 0;
            double xh = 0;
            double yhf = 0;
            double fh = 0;

            for (int i = 0; i <= 20; i++)
            {
                y = y + dely;
                x = i * h;
                xh = x + h;
                f_x_y = CalcF_X_Y(x, y);
                yhf = y + h * f_x_y;
                fh = CalcF_X_Y(xh, yhf);
                dely = (h / 2) * (f_x_y + fh);
                toch_y = F(x);
                error = Math.Abs(toch_y - y);
                Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}  {4,10}  {5,10}  {6,10}  {7,10}  {8,10}",
                Math.Round(x, 5), Math.Round(y, 5), Math.Round(f_x_y, 5), Math.Round(xh, 5),
                Math.Round(yhf, 5), Math.Round(fh, 5), Math.Round(dely, 5), Math.Round(toch_y, 5), Math.Round(error, 5));
            }
        }

        private double CalcF_X_Y(double x, double y)
        {
            return 2 * x * x + 3 * y;
        }

        private double F(double x)
        {
            return 0.348148 * Math.Pow(Math.E, 3 * x) - 0.444444 * x - 0.666667 * x * x - 0.148148;
        }
    }
}
