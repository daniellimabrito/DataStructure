using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms
{
    public class LinkedListAlgo<T>
    {
        private int _size = 0;
        private Node<T> _head = null;
        private Node<T> _tail = null;
        private IList _list = null;

        public List<T> List = new List<T>();
        public IList List1{ get => _list; set => _list = value; }

        public class Node<U> 
        {
            public T _data;
            public Node<T> _prev, _next;

           public Node(T data, Node<T> prev,Node<T> next)
           {
               _data = data;
               _prev = prev;
               _next = next;

           }
        }

        public List<T> GetCurrentList()
        {
            var trav = _head;
            while (trav != null) {
                List.Add(trav._data);
                trav = trav._next;
            }
            return List;
        }

        public int Size() 
        {
            return _size;
        }

        public bool IsEmpty() {
            return Size() == 0;
        }

       public void AddLast(T elem)
       {
           if (IsEmpty())
           {
               _head = _tail = new Node<T>(elem, null, null);
           }
           else {
               _tail._next = new Node<T>(elem, _tail, null);
               _tail = _tail._next;

           }

           _size++;
       }

       public void AddFirst(T elem)
       {
           if (IsEmpty())
           {
               _head = _tail = new Node<T>(elem, null, null);
           }
           else {
               _head._prev = new Node<T>(elem, null, _head);
               _head = _head._prev;

           }

           _size++;
       }

       public T PeekFirst()
       {
           if (IsEmpty())
           {
               throw new Exception("No found results");
           }

           return _head._data;
       }

       public T PeekLast()
       {
           if (IsEmpty())
           {
               throw new Exception("No found results");
           }

           return _tail._data;
       }

       public T RemoveFirst()
       {
           if (IsEmpty())
           {
               throw new Exception("No found results");
           }

           var removedNode = _head;

            _head = _head._next;

            _head._prev = null;

            return removedNode._data;
       }       
   
    }
}