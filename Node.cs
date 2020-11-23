namespace Stack.shared
{
    public class Node<T>
    {
        public T data;
        public Node<T> next = null;

        public Node(T value)
        {
            data = value;
        }
    }
}