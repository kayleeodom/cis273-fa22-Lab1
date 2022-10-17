using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthToLast
{
    public class DoublyLinkedListNode<T>
    {
        public T Data { get; set; }
        public DoublyLinkedListNode<T> Prev { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }

        public DoublyLinkedListNode(T data = default(T), DoublyLinkedListNode<T> prev = null, DoublyLinkedListNode<T> next = null)
        {
            Data = data;
            Next = next;
            Prev = prev;

        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
    public class DoublyLinkedList<T>: IList<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
        }
        public T? First => IsEmpty ? default(T) : Head.Data; //IsEmpty ? default(T): 
        public T? Last => IsEmpty ? default(T) : Tail.Data;

        public IsEmpty { get => Length == 0; }
        
        private int length = 0;
            
        public void Append(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value):

            if (IsEmpty)
            {

            }
            else
            {
                Tail.Next = newNode;
                newNode.Prev = Tail;
                Tail = newNode
            }

            length++;
        }


        public void Clear()
        {
        throw new ArgumentOutOfRangeException();
        }
        public bool Contains(Task Value)
        {
            if (length == -1)
            {
                return false;
            }

                // traverse

        }

        // Things to change: InsertAfter, InsertAt, Remove, RemoveAt
        public void InsertAt(Task value, int index)
        {

            while (currentNode != null)
            {
                if (currentIndex == index - 1)
                {
                    var newNode = new DoublyLinkedListNode<T>(value);

                    currentNode.Next.Prev = newNode
                        newNode.Next = currentNode.Next;
                    currentNode.Next = newNode;
                    newNode.Prev = currentNode;
                }
            }

        }
    }
}
