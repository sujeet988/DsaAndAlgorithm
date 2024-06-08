
Console.WriteLine("PriorityQueue Example");
var  priorityQueue = new PriorityQueue<int,int>();
priorityQueue.Enqueue(3, 33);
priorityQueue.Enqueue(4, 4);
priorityQueue.Enqueue(1, 10);
priorityQueue.Enqueue(7, 7);

while (priorityQueue.Count > 0)
{
    Console.WriteLine(priorityQueue.Peek());
    priorityQueue.Dequeue();
}
Console.ReadLine();

