namespace LinkedListAllOperation
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Operation");
            LinkedList obj=new LinkedList();
            for(int i = 0;i < 5; i++)
            {
                obj.InsertAtLast(i);
            }
            obj.DisplayNode();
            Console.ReadLine(); 

        }
    }
}