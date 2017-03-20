using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANN.Neurons
{
    public interface INeuralNet
    {
        void ApplyLearning();
        void Pulse();

        INeuralLayer HiddenLayer { get; set; }
        INeuralLayer OutputLayer { get; set; }
        INeuralLayer PerceptionLayer { get; set; }
    }
}
