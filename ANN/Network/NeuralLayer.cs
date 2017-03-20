using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANN.Neurons;

namespace ANN.Network
{
    public class NeuralLayer : INeuralLayer
    {
        List<INeuron> m_neurons { get; set; }
        public INeuron this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } // help :(

        public int Count { get; set; }

        public bool IsReadOnly { get; set; }

        public NeuralLayer()
        {

        }

        public void Add(INeuron item)
        {
            
        }

        public void ApplyLearning(INeuralNet net)
        {
            foreach (INeuron n in m_neurons)
                n.ApplyLearning(this);
        }

        public void Clear()
        {
            
        }

        public bool Contains(INeuron item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(INeuron[] array, int arrayIndex)
        {
            
        }

        public IEnumerator<INeuron> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(INeuron item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, INeuron item)
        {
            
        }

        public void Pulse(INeuralNet net)
        {
            foreach (INeuron n in m_neurons)
                n.Pulse(this);
        }

        public bool Remove(INeuron item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
