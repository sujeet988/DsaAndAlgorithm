namespace LruImp
{
    public class LRUCache
    {
        Dictionary<int, int> cache;
        private int cap;
        int size;
        List<int> list;


        public LRUCache(int capacity)
        {
            this.cache = new Dictionary<int, int>();
            this.list = new List<int>();
            this.cap = capacity;
            size = 0;
                    
        }

        public int get(int key)
        {
            if (cache.ContainsKey(key))
            {
                list.Remove(key);
                list.Add(key);
                return cache[key];
            }
            else
            {
                return -1;
            }
        }

        public void put(int key, int value) 
        {
            if (!cache.ContainsKey(key))
            {
                if(cache.Count == cap)
                {
                    cache.Remove(list[0]);
                    list.Remove((list[0]));
                }

                list.Add(key);
                cache.Add(key, value);
            }
            else 
            {
                list.Remove(key);
                list.Add(key);
                cache.Add(key, value);

            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("LRU Cache Demo");
            LRUCache lru = new LRUCache(3);
            lru.put(100,1000);
            lru.put(101, 10001);
            lru.put(102, 1002);

            lru.put(103, 1003);


           Console.WriteLine(lru.get(100));
            Console.WriteLine(lru.get(102));
            Console.WriteLine(lru.get(103));


            Console.ReadLine();
        }
    }

    //https://leetcode.com/problems/lru-cache/solutions/5052192/c-simple-solution/
}