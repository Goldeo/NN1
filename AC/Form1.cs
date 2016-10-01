using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AC.Network;

namespace AC
{
    public partial class Form1 : Form
    {
        NeuralNetWork network;
        double aChart;
        double bChart;
        int pointsCount;
        List<double> xNoise;
        List<double> yNoise;
        int type;

        private int hiddenNeuronsCount;
        private double xA;
        private double xB;
        private int hiddenLayersCount;
        private static readonly Random rand2 = new Random(Environment.TickCount);
        private static readonly Random rand = new Random(rand2.Next(Environment.TickCount));

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hiddenNeuronsCount = int.Parse(neuronsCount_tb.Text);
            hiddenLayersCount = int.Parse(hiddenLayersCount_tb.Text);

            if (radioButton1.Checked) type = 0;
            if (radioButton2.Checked) type = 1;
            if (radioButton3.Checked) type = 2;
            
            xA = double.Parse(a_tb.Text);
            xB = double.Parse(b_tb.Text);

            progressBar.Value = 1;

            xNoise = new List<double>();
            yNoise = new List<double>();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i) {
                try {
                    xNoise.Add(double.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                    yNoise.Add(double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                }

                catch { }
            }
            int xCount = int.Parse(tb_x.Text);
            network = new NeuralNetWork(1, hiddenLayersCount, hiddenNeuronsCount, 1);

            progressBar.Maximum = xCount;
            
            //Массивы x и y для обучения

            //y от функции
            for (int i = 0; i < xCount; ++i) {
                network.xList.Add(rand.NextDouble() * (xB - xA) + xA);
                network.yList.Add(MyChart.Func(network.xList[i], type));    
            }

            //y шум
            /*for (int i = 0; i < xNoise.Count; ++i) {
                network.xList.Add(xNoise[i]);
                network.yList.Add(yNoise[i]);
            }*/

            network.xMin = network.FindMin(network.xList, 0);
            network.xMax = network.FindMax(network.xList, 0);
            network.yMin = network.FindMin(network.yList, 0);
            network.yMax = network.FindMax(network.yList, 0);

            //Нормализовать
            for (int i = 0; i < xCount; ++i) {
                network.xNormList.Add((network.xList[i] - network.xMin) / (network.xMax - network.xMin));
                network.yNormList.Add((network.yList[i] - network.yMin) / (network.yMax - network.yMin));
            }

            //Обучение сети
            for (int i = 0; i < xCount; ++i) {
                 network.SetValues(network.xNormList[i], network.yNormList[i]);

                 do {
                    network.Cicle();
                    network.ReverseCicle();
                 } while (Math.Abs(network.realOutput - network.output) >= 0.005) ;

                if (progressBar.Value < xCount)
                    ++progressBar.Value;
            }         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aChart = double.Parse(aChart_tb.Text);
            bChart = double.Parse(bChart_tb.Text);
            pointsCount = int.Parse(pointsCount_tb.Text);
            int noisePointsCount = dataGridView1.Rows.Count - 1;

            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
           // chart.Series[2].Points.Clear();

            //Точки
            double x2, y2;

            List<double> yCalculated = new List<double>();
            
            MyChart myChart = new MyChart(aChart, bChart, type, pointsCount, xNoise, yNoise);
            myChart.Build(chart, 1); //Исходный ряд
            //myChart.Build(chart, 2, xNoise, yNoise); //Шум

            for (int i = 0; i < myChart.pointsCount; ++i) {
                try {
                    x2 = (myChart.x[i] - network.xMin) / (network.xMax - network.xMin);

                    network.layers[0].neurons[0].output = x2; //Вход нейросети
                    network.Cicle();
                    
                    y2 = network.realOutput;
                    yCalculated.Add(y2 * (network.yMax - network.yMin) + network.yMin);
                }
                
                catch { }
            }

            myChart.Build(chart, 0, yCalculated); //Расчетный ряд
            myChart.FindR2();
            R2_tb.Text = myChart.R2.ToString();
       }
            
    }
}
