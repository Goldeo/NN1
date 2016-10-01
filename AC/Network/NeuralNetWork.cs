using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AC.Network
{
    class NeuralNetWork
    {
        private int hiddenLayersCount;
        public double output;
        public List<Layer> layers;
        public int layerCount;
        public static double norm = 0.85;
        public double realOutput;
        public double error = 1;
        public double xMin, yMin, xMax, yMax;

        public List<double> xList = new List<double>();
        public List<double> yList = new List<double>();
        public List<double> xNormList = new List<double>();
        public List<double> yNormList = new List<double>();

        public NeuralNetWork(int inputNeuronsCount, int hiddenLayersCount, int hiddenNeuronsCount, int outputNeuronsCount) {
            this.hiddenLayersCount = hiddenLayersCount;
            
            layers = new List<Layer>();
            //Создание слоев
            layers.Add(new Layer(inputNeuronsCount, Layer.TYPE.INPUT));
            for (int i = 0; i < hiddenLayersCount; ++i)
                layers.Add(new Layer(hiddenNeuronsCount, Layer.TYPE.HIDDEN));
            layers.Add(new Layer(outputNeuronsCount, Layer.TYPE.OUTPUT));
            layerCount = layers.Count;

            //Установить количество весов для нейронов и их значения
            for (int i = 0; i < layers.Count - 1; ++i)
            {
                layers[i].SetNewWeights(layers[i + 1]);
            }

        }

        public void SetValues(double x, double y) {
            layers[0].neurons[0].output = x;
            //
            output = y;
            layers[layers.Count - 1].neurons[0].output = output;
        }

        //Прямой ход
        public void Cicle() {
       
            for (int i = 1; i < layerCount; ++i) {
                for (int j = 0; j < layers[i].neurons.Count; ++j) {
                    layers[i].neurons[j].FindOutput(layers[i - 1], j);
                }
            }

            //Для выходного слоя
            realOutput = layers[layers.Count - 1].neurons[0].output;
            FindNWError();
        }

        //Обратный ход (метод обратного распространения ошибки)
        public void ReverseCicle() {
            //с 1 по 0 слои
            for (int i = layers.Count - 2; i >= 0; --i){
                for (int j = 0; j < layers[i].neurons.Count; ++j) {
                    layers[i].neurons[j].FindError(layers[i + 1]);
                }
            }

            for (int i = 0; i < layers.Count - 1; ++i) {
                for (int j = 0; j < layers[i].neurons.Count; ++j)
                    layers[i].neurons[j].SetWeights(layers[i + 1]);
            }
        }

        public void FindNWError() {
            error = (output - realOutput) * realOutput * (1 - realOutput);
            layers[layers.Count - 1].neurons[0].error = error;
        }

        public double FindMin(List<double> list, int xNoise) {
            double min = list[0];
            for (int i = 1; i < list.Count - xNoise; ++i) {
                if (list[i] < min) 
                    min = list[i];
            }
            return min;
        }

        public double FindMax(List<double> list, int xNoise)
        {
            double max = list[0];
            for (int i = 1; i < list.Count - xNoise; ++i) {
                if (list[i] > max) 
                    max = list[i];
            }
            return max;
        }

    }
}
