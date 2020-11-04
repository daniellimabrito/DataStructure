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
            public T data;
            public Node<T> prev, next;

           public Node(T pData, Node<T> pPrev,Node<T> pNext)
           {
               data = pData;
               prev = pPrev;
               next = pNext;

           }
        }

        public List<T> GetCurrentList()
        {
            var trav = _head;
            while (trav != null) {
                List.Add(trav.data);
                trav = trav.next;
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
               _tail.next = new Node<T>(elem, _tail, null);
               _tail = _tail.next;

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
               _head.prev = new Node<T>(elem, null, _head);
               _head = _head.prev;

           }

           _size++;
       }

       public T PeekFirst()
       {
           if (IsEmpty())
           {
               throw new Exception("No found results");
           }

           return _head.data;
       }

       public T PeekLast()
       {
           if (IsEmpty())
           {
               throw new Exception("No found results");
           }

           return _tail.data;
       }

       public T RemoveFirst()
       {
           if (IsEmpty())
           {
               throw new Exception("No found results");
           }

           var removedNode = _head;

            _head = _head.next;

            _head.prev = null;

            return removedNode.data;
       }       
   
    }
}