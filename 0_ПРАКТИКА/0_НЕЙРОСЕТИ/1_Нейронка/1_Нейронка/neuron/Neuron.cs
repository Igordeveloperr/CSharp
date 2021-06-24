using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Нейронка.neuron
{
    internal class Neuron
    {
        // создание весов
        public List<double> Weights { get; }
        // тип нейрона
        public NeuronType NeuronType { get; }
        // результат работы нейрона
        public double OutPut { get; private set; }
        // в конструктор принимает количество входящих связей и тип нейрона
        public Neuron(int inputCount, NeuronType type = NeuronType.Normal)
        {
            if (inputCount == 0) throw new ArgumentException("0 входящих связей");
            NeuronType = type;
            Weights = new List<double>();
            for(int i = 0; i < inputCount; i++)
            {
                Weights.Add(1);
            }
        }

        // метод принимает список входных сигналов
        public double FeedForward(List<double> inputs)
        {
            double sum = 0.0;
            for(int i = 0; i < inputs?.Count; i++)
            {
                sum += inputs[i] * Weights[i];
            }
            OutPut = Sigmoid(sum);
            return OutPut;
        }

        // описываю функцию сигмоиды
        private double Sigmoid(double x)
        {
            double result = 1.0 / (1.0 + Math.Pow(Math.E, -x));
            return result;
        }
        public override string ToString()
        {
            return OutPut.ToString();
        }
    }
}
