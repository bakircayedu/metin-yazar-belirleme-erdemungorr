using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    public class StackUsingLinkedlist<T> : IEnumerable<T>
    {
        private T[] data;
        public int size;

        // A linked list node
        private class Node
        {
            // integer data
            public object data;

            // reference variable Node type
            public Node link;
        }

        Node top;

        public StackUsingLinkedlist()
        {
            this.top = null;
        }

        
        public void push(object x)
        {
            // create new node temp and allocate memory
            Node temp = new Node();

            // check if stack (heap) is full.
            // Then inserting an element
            // would lead to stack overflow
            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }

            // initialize data into temp data field
            temp.data = x;

            // put top reference into temp link
            temp.link = top;

            // update top reference
            top = temp;
        }

        // Utility function to check if
        // the stack is empty or not
        public bool isEmpty()
        {
            return top == null;
        }

        // Utility function to return
        // top element in a stack
        public object peek()
        {
            // check for empty stack
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }

        // Utility function to pop top element from the stack
        public void pop() // remove at the beginning
        {
            // check for stack underflow
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }

            // update the top pointer to
            // point to the next node
            top = (top).link;
        }

        public void display()
        {
            // check for stack underflow
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {

                    // print node data
                    Console.Write("{0}->", temp.data);

                    // assign temp link to temp
                    temp = temp.link;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = size - 1; i >= 0; i--)
            {
                yield return data[i];
            }


        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

   
    
    
}
