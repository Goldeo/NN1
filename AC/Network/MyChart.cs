using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace AC.Network
{
    class MyChart
    {
        public List<double> x;
        public double R2;
        public List<double> yOriginal;
        public List<double> yCalculated;

        private double step;
        public int pointsCount;
        private double a;
        private double b;

        public MyChart(double a, double b, int type, int pointsCount, List<double> xNoise, List<double> yNoise) {
            this.pointsCount = pointsCount;

            this.a = a;
            this.b = b;
            x = new List<double>();
            yOriginal = new List<double>();
            step = (b - a) / pointsCount;

            //Добавить точки функции
            for (double i = a; i < b; i += step) {
                x.Add(i);
                yOriginal.Add(Func(x[x.Count - 1], type));
            }

        }

        public void Build(Chart chart, int seriesNumber) {
            for (int i = 0; i < pointsCount; ++i) {
                chart.Series[seriesNumber].Points.AddXY(x[i], yOriginal[i]);
            }

        }

        public void Build(Chart chart, int seriesNumber, List<double> y) {
            yCalculated = y;
            for (int i = 0; i < pointsCount; ++i) {       
                chart.Series[seriesNumber].Points.AddXY(this.x[i], y[i]);
            }
        }

        public void FindR2() {
            double yMiddle = 0;
            double RSS = 0, TSS = 0;

            for (int i = 0; i < pointsCount; ++i) {
                yMiddle += yOriginal[i];
            }
            yMiddle /= pointsCount;
            
            for (int i = 0; i < pointsCount; ++i) {
                RSS += (yOriginal[i] - yCalculated[i]) * (yOriginal[i] - yCalculated[i]);
                TSS += (yOriginal[i] - yMiddle) * (yOriginal[i] - yMiddle);
            }

            R2 = 1 - RSS / TSS;

        }

        public static double Func(double x, int type)  {
            switch (type) {
                case 0:
                    return x * x;
                case 1:
                    return  Math.Sin(x);
                case 2:
                    return Math.Sqrt(x) + Math.Sin(2 * x * x);
                default:
                    return 0;
            }
        }

    }
}
