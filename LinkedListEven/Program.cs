namespace LinkedListEven
{
    internal class Program
    {

        public class SinglyLinkedList
        {
            public int data;
            public SinglyLinkedList next;
        }

        public static SinglyLinkedList Even(SinglyLinkedList head)
        {
            SinglyLinkedList temp = head;
            SinglyLinkedList temp1 = null;
            while (temp != null)
            {
               if(temp.data %2  == 0)
                {

                    if(temp1 == null)
                    {
                        temp1 = new SinglyLinkedList();
                        temp1.data = temp.data;

                    }
                    else
                    {
                        var temp2 = new SinglyLinkedList();
                        temp2.data = temp.data;
                        temp1.next = temp2;
                    }

                    if(temp.next != null)
                    {
                        temp = temp.next;
                    }
                        
                    

                }
                else
                {
                    temp = temp.next;
                }
            }
            return temp1;
        }

        public static void PrintSinglyLinkedList(SinglyLinkedList head)
        {
            SinglyLinkedList temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SinglyLinkedList li1 = new SinglyLinkedList();
            SinglyLinkedList li2 = new SinglyLinkedList();
            SinglyLinkedList li3 = new SinglyLinkedList();
            SinglyLinkedList li4 = new SinglyLinkedList();
            SinglyLinkedList li5 = new SinglyLinkedList();
            li1.data = 1;
            li2.data = 2;
            li3.data = 3;
            li4.data = 6;
            li5.data = 9;
            li1.next = li2;
            li2.next = li3;
            li3.next = li4;
            li4.next = li5;

            PrintSinglyLinkedList(li1);
            Console.WriteLine();
            var result = Even(li1);
            PrintSinglyLinkedList (result);


            Console.ReadLine();
        }
    }
}
