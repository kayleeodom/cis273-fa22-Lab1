using System.Collections.Generic;
using System.Security;

namespace Palindrome;
public class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        linkedList.AddLast("xbx");
        linkedList.AddLast("pka");
        linkedList.AddLast("pka");
        linkedList.AddLast("xbx");

    }

    public static bool IsPalindrome<T>(LinkedList<T> linkedList)
    {

        // are the first and last items the same?
        //var back = linkedList.Reverse(); // last item not an linked list anymore
        var currentNode = linkedList.First; // first idea
        var back = linkedList.Last;
        //var currentNodeReverse = linkedList.ReverseFirst();

        while(currentNode != null)
        {
            //currentNode = currentNode.Next;
            if(currentNode.Equals(back))
            {
                currentNode = currentNode.Next;
            }
            else
            {
                return false;
            }
        }

        foreach(var node in linkedList)
        {
            Console.WriteLine(node);
            //Console.WriteLine(Reverse.Equals(linkedList));
        }

        return true;
    }
                
}

