namespace Lecture_LinkedList;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> ll = new LinkedList<int>();
        
        ll.AddLast(1);
        ll.AddLast(2);
        ll.AddLast(3);

        LinkedListNode<int> node = ll.First;
        LinkedListNode<int> prevNode = node.Previous;

    }
}