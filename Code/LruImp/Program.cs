namespace LruImp
{
    internal class LRUCache
    {
        Dictionary<int,int> cache = new Dictionary<int,int>();
        int Capacity;

        public LRUCache(int capacity)
        {
            this.Capacity = capacity;
                    
        }

        public int get(int key)
        {
            return cache[key];
        }

        public void put(int key, int value) 
        {
            cache[key] = value;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("LRU Cache Demo");
            Console.ReadLine();
        }
    }
}