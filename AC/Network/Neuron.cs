using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AC.Network
{
    class Neuron
    {
        private static readonly Random rand2 = new Random(Environment.TickCount);
        private static readonly Random rand = new Random(rand2.Next(Environment.TickCount));

        public List<double> weights = new List<double>();
        public double output;
        public double error;

        public void FindOutput(Layer lastLayer, int index) {
            double s = 0;

            for (int i = 0; i < lastLayer.neurons.Count; ++i)
                s += lastLayer.neurons[i].output * lastLayer.neurons[i].weights[index];

            output = TransferFunction(s);
        }

        //Сигмоидальная функция
        private static double TransferFunction(double s) {
            return 1 / (1 + Math.Exp(-s));
        }

        public void FindError(Layer nextLayer) {       
            double sum = 0;
            
            for (int i = 0; i < nextLayer.neurons.Count; ++i)
                sum += weights[i] * nextLayer.neurons[i].error;
            
            error = sum * output * (1 - output);
        }

        public void SetWeights(Layer nextLayer) {
            for (int i = 0; i < nextLayer.neurons.Count; ++i)
                weights[i] = weights[i] + NeuralNetWork.norm * nextLayer.neurons[i].error * output;
                
        }

    }
}
