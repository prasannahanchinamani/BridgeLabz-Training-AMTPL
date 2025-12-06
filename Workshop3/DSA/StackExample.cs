namespace DSA
{
    internal class StackExample<T>
    {
        int size = 0;
        LinkedListExample<T> list = new LinkedListExample<T>();

        public void Push(T data)
        {
            list.AddAtStarting(data);
            size++;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            return list.head.Data;
        }

        public void Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            list.DeleteAtstarting();
            size--;
        }

        public int CountStack()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }
    }
}