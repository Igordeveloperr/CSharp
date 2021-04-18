using _1_Нейронка.layer;
using _1_Нейронка.neuron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Нейронка.network
{
    // сеть нейронов
    internal class NeuralNetwork
    {
        // все слои, которые есть в нейронной сети
        public List<Layer> Layers { get; }
        // инфа о нейронке
        public Topology Topology { get; }
        public NeuralNetwork(Topology topology)
        {
            if (topology == null) throw new ArgumentException("инфа пустая");
            Topology = topology;
            Layers = new List<Layer>();
            CreateInputLayer();
            CreateHiddenLayers();
            CreateOutputLayer();
        }
        public double FeedForward(List<double> inputSignals)
        {
            SendSignalsToInputNeurons(inputSignals);
            for (int i = 1; i < Layers.Count; i++)
            {
                var layer = Layers[i];
                var prevLayerSignals = Layers[i - 1].GetSignals();
            }
        }

        private void SendSignalsToInputNeurons(List<double> inputSignals)
        {
            if (inputSignals.Count == Topology.InputCount)
            {
                for (int i = 0; i < inputSignals.Count; i++)
                {
                    var signal = new List<double>() { inputSignals[i] };
                    var neuron = Layers[0].Neurons[i];
                    neuron.FeedForward(signal);
                }
            }
        }

        // создаю выходной слой
        private void CreateOutputLayer()
        {
            var outputNeurons = new List<Neuron>();
            var lastLayer = Layers.Last();
            for (int i = 0; i < Topology.OutputCount; i++)
            {
                Neuron neuron = new Neuron(lastLayer.NeuronsCount, NeuronType.OutPut);
                outputNeurons.Add(neuron);
            }
            var outputLayer = new Layer(outputNeurons, NeuronType.OutPut);
            Layers.Add(outputLayer);
        }
        // создаю скрытый слой
        private void CreateHiddenLayers()
        {
            for(int j = 0; j < Topology.HiddenLayers.Count; j++)
            {
                var hiddenNeurons = new List<Neuron>();
                var lastLayer = Layers.Last();
                for (int i = 0; i < Topology.HiddenLayers[j]; i++)
                {
                    Neuron neuron = new Neuron(lastLayer.NeuronsCount);
                    hiddenNeurons.Add(neuron);
                }
                var hiddenLayer = new Layer(hiddenNeurons, NeuronType.Input);
                Layers.Add(hiddenLayer);
            }
        }
        // создаю входной слой
        private void CreateInputLayer()
        {
            var inputNeurons = new List<Neuron>();
            for(int i = 0; i < Topology.InputCount; i++)
            {
                Neuron neuron = new Neuron(1, NeuronType.Input);
                inputNeurons.Add(neuron);
            }
            var inputLayer = new Layer(inputNeurons, NeuronType.Input);
            Layers.Add(inputLayer);
        }
    }
}
