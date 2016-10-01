using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AC.Network
{
    class Layer
    {
        public enum TYPE {
            INPUT, 
            HIDDEN,
            OUTPUT
        }

        private static readonly Random rand2 = new Random(Environment.TickCount);
        private static readonly Random rand = new Random(rand2.Next(Environment.TickCount));
        public List<Neuron> neurons = new List<Neuron>();
        public int neuronsCount;
        public TYPE type;


        public Layer(int neuronsCount, TYPE type) {
            this.neuronsCount = neuronsCount;
            this.type = type;
            for (int i = 0; i < neuronsCount; ++i) {
                neurons.Add(new Neuron());
            }
        }

        public void SetNewWeights(Layer nextLayer) {
            for (int i = 0; i < neurons.Count; ++i)
                for (int j = 0; j < nextLayer.neurons.Count ; ++j) {
                    neurons[i].weights.Add(rand.NextDouble() * (10) - 5);
                }
        }

    }  
}
