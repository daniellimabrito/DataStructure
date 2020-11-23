using System;
using System.Collections.Generic;

namespace Stack.shared
{
    public class MyStack<T>
    {
        public MyStack()
        {
        }
        private Node<T> top;


        private bool IsEmpty() {
            return top == null;
        }

        public T Pop() {
            if (IsEmpty()) throw new System.Exception("Stack is empty");

            var item = top.data;
            top = top.next;

            return item;
        }

        public void Push(T item) {

            var newNode = new Node<T>(item);

            newNode.next = top;
            top = newNode;
        }

        public T Peek() {
            if (IsEmpty()) throw new System.Exception("Stack is empty");

            return top.data;
        }

        public Node<T> GetStack() {
            return top;
        }

    }
}