using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Нейронка.network
{
    // описание нашей нейронки
    internal class Topology
    {
        // кол-во входов в нейронную сеть 
        public int InputCount { get; }
        // кол-во выходов из сети
        public int OutputCount { get; }
        // список скрытых слоев
        public List<int> HiddenLayers { get; }
        public Topology(int inputCount, int outputCount, params int [] layers)
        {
            InputCount = inputCount;
            OutputCount = outputCount;
            HiddenLayers = new List<int>();
            HiddenLayers.AddRange(layers);
        }
    }
}
