using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANN.Neurons;

namespace ANN.Network
{
    class Neuron : INeuron
    {
        NeuralFactor m_bias;
        double m_biasWeight;
        double m_error;
        Dictionary<INeuronSignal, NeuralFactor> m_input;
        double m_output;

        public NeuralFactor Bias { get; set; }
        public double BiasWeight { get; set; }
        public double Error { get; set; }
        public double Output { get; set; }
        public Dictionary<INeuronSignal, NeuralFactor> Input { get; set; }

        public Neuron()
        {

        }

        public void ApplyLearning(INeuralLayer layer)
        {

        }

        public void Neurons(int i) // Neuron? overload
        {

        }

        public void Pulse(INeuralLayer layer)
        {
            lock (this)
            {
                m_output = 0;

                foreach (KeyValuePair<INeuronSignal, NeuralFactor> item in m_input)
                    m_output += item.Key.Output * item.Value.Weight;

                m_output += m_bias.Weight * BiasWeight;

                m_output = Sigmoid(m_output);
            }
        }

        private static double Sigmoid(double value)
        {
            return 1 / (1 + Math.Exp(-value));
        }
    }
}
