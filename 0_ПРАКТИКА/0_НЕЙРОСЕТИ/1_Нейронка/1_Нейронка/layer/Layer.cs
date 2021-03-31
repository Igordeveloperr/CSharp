using _1_Нейронка.neuron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Нейронка.layer
{
    // описываем слой
    internal class Layer
    {   
        // список всех нейронов в слое
        public List<Neuron> Neurons { get; }
        // кол-во нейронов в слое
        public int NeuronsCount => Neurons?.Count ?? 0;
        public Layer(List<Neuron> neurons, NeuronType type = NeuronType.Normal)
        {
            if (neurons == null) throw new ArgumentException("0 нейронов в слое!");
            Neurons = neurons;
        }
        // сбор сигналов со слоя
        public List<double> GetSignals()
        {
            var result = new List<double>();
            foreach(var neuron in Neurons)
            {
                result.Add(neuron.OutPut);
            }
            return result;
        }
    }
}
