namespace FIFO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShiftQueue q = new ShiftQueue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
        }

        class ShiftQueue
        {
            private int[] queue;
            private int front;
            private int rear;

            public ShiftQueue()
            {
                queue = new int[100];
                front = 0;
                rear = 0;
            }

            public bool IsEmpty()
            {
                return (front == rear);
            }

            public int Size()
            {
                return (rear - front);
            }

            public void Enqueue(int item)
            {
                queue[rear++] = item;
            }

            public int Dequeue()
            {
                if (IsEmpty())
                {
                    return -1;
                }
                int item = queue[front++];
                if (front == rear)
                {
                    front = 0;
                    rear = 0;
                }
                return item;
            }
        }
    }
}