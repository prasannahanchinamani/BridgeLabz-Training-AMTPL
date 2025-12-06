
namespace DSA
{
    //FIFO
    internal class QueueExample<T>
    {
        int size = 0;
        LinkedListExample<T> list = new LinkedListExample<T>();
        public void Enqueue(T data)
        {
          list.AddAtend(data);
            size++;
        }
        public void Deque()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            list.DeleteAtstarting();
            size--;

        }
        public T Peek()
        {
            return list.head.Data;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }
    }
}
