namespace ConsoleApp1
{
    internal class Queue<T>
    {
        T[] collection;

        int start;
        int end;

        public Queue()
        {
            collection = new T[10];
            start = 0;
            end = 0;
        }

        public void push (T item)
        {
            if (end == collection.Length)
            {
                Console.WriteLine("queue is full");
            }
            else { collection[end++] = item; }
        }

        public T pop () {

            if (start == end)
            {
                Console.WriteLine("queue is empty");
                return default(T);
            }
            else { return collection[start++]; }
        }

    }
}
