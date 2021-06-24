using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Связный_список
{
    // класс узла, который представляет одиночный элемент в связном списке
    internal class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            Data = data;
        }
    }
}
