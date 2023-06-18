
// See https://aka.ms/new-console-template for more information


Console.WriteLine("PriorityQueue Example");


var  priorityQueue = new PriorityQueue<int,int>();
priorityQueue.Enqueue(3, 3);
priorityQueue.Enqueue(4, 4);
priorityQueue.Enqueue(1, 1);
priorityQueue.Enqueue(7, 7);

while (priorityQueue.Count > 0)
{
    Console.WriteLine(priorityQueue.Peek());
    priorityQueue.Dequeue();
}
Console.ReadLine();

