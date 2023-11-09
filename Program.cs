using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            ShohbozTuplami<string> result = new ShohbozTuplami<string> ();
            result.Add("hello");
            result.Add("world");
            Console.WriteLine(result.Count);

            //foreach (string item in result)
            //{
            //    Console.Write(item.ToUpper());
            //}
        }
    }
    class ShohbozTuplami<T> : IList<T>
    {
        private List<T> _items;
        public ShohbozTuplami()
        {
            _items = new List<T>();
        }
        public T this[int index] 
        {
            get
            {
                return _items[index];
            } 
            set
            {
                _items[index] = value;

            } 
        }
        public int Count
        {
            get
            {
                return _items.Count;
            }    
        }
        
        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            _items.Add(item);
            
        }

        public void Clear()
        {
            _items?.Clear();
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            return _items.Remove(item);
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}