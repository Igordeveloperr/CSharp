using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1_Связный_список
{   
    // связный список
    internal class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; private set; } // первый элемент
        public Node<T> Tail { get; private set; } // последний элемент
        public int Count { get; private set; } // кол-во элементов в списке
        // добавление элемента
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            // первый элемент списка
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                // ссылка на новый узел
                Tail.Next = node;
            }
            Tail = node;
            Count++;
        }
        // удаление элемента
        public void Remove(T data)
        {
            Node<T> current = Head;
            Node<T> previos = null;
            while(current != null)
            {
                // если введеные данные совпали с данными в списке
                if (current.Data.Equals(data))
                {
                    // если узел находится в середине или в конце
                    if(previos != null)
                    {
                        previos.Next = current.Next;
                        if(current.Next == null)
                        {
                            Tail = previos;
                        }
                    }
                    else
                    {
                        Head = Head.Next;
                        if (Head == null) Tail = null;
                    }
                    Count--;
                }
                previos = current;
                current = current.Next;
            }
        }
        // добавление первым
        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            // новая нода имеет ссылку на элемент, который до ее добавления был первым
            node.Next = Head;
            // переопределяем начальный элемент списка
            Head = node;
            if (Count == 0) Tail = Head;
            Count++;
        }
        // реализую интерфасе, чтобы можно было перебирать наш список
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
