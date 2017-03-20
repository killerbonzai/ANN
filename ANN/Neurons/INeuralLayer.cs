using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANN.Neurons
{
    public interface INeuralLayer : IList<INeuron>
    {
        void Pulse(INeuralNet net);
        void ApplyLearning(INeuralNet net);
    }
}
