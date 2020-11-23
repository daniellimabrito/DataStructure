using System;

namespace Queue.Shared
{
    public class MyQueue<T>
    {
        private Node<T> first;
        private Node<T> last;

        private bool IsEmpty() {
            return first == null;
        }

        public void Push(T item) {
            
            var newItem = new Node<T>(item);

            if (last != null)
                last.next = newItem;

            last = newItem;

            if (first == null)
                first = last;
        }

        public T Remove() {

            if (IsEmpty()) throw new System.Exception("Queue is empty");

            var data = first.data;

            first = first.next;
            if (first == null)
                last = null;

            return data;
        }

        public T Peek() {
            return first.data;
        }

        public Node<T> GetCurrentQueue() {
           
            return first;
        }

    }
}