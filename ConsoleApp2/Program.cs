using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);

        Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

        if (myStack.Count > 0)
        {
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Peek());
        }

        Console.WriteLine("Number of elements in sStack: {0}", myStack.Count);




        Stack<int> myStack1 = new Stack<int>();
        myStack1.Push(1);
        myStack1.Push(2);
        myStack1.Push(3);
        myStack1.Push(4);

        Console.Write("Number of elements in Stack: {0}", myStack1.Count);

        if (myStack1.Count > 0)
        {
            Console.WriteLine(myStack1.Peek()); 
            Console.WriteLine(myStack1.Peek());
        }

        Console.Write("Number of elements in Stack: {0}", myStack1.Count);


        Stack<int> myStackk = new Stack<int>();
        myStackk.Push(1);
        myStackk.Push(2);
        myStackk.Push(3);
        myStackk.Push(4);

        Console.Write("Number of elements in Stack: {0}", myStackk.Count);

        while (myStackk.Count > 0)
            Console.Write(myStackk.Pop() + ",");

        Console.Write("Number of elements in Stack: {0}", myStackk.Count);


        Stack<int> myStackc = new Stack<int>();
        myStackc.Push(1);
        myStackc.Push(2);
        myStackc.Push(3);
        myStackc.Push(4);

        myStackc.Contains(2);
        myStackc.Contains(10); 

    }


}
 


