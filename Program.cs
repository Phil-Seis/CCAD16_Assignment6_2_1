// Write a C# program to implement a stack by using array with push and pop operations.
// Top is most important in a stack, it's the only thing you can see or access
// Need a pointer 

using System;

namespace CCAD16_Assignment6_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(5); // Create an instance of Stack with a size of 5 elements

            //operational test 1
            stack.Push();
            stack.Push();
            stack.Push();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            //operation test 2
            //stack.Push();
            //stack.Push();
            //stack.Push();
            //stack.Push();
            //stack.Push();
            //stack.Push();
        }
    }

    //Class for the stack
    public class Stack
    {
        private int[] stackArray;
        private int top;
        private int nextValue;

        //constructor for the stack
        public Stack(int size)
        {
            stackArray = new int[size];
            top = -1;
            nextValue = 1;
        }

        //method for push
        public void Push()
        {            
            if (top == stackArray.Length - 1)
            {
                Console.WriteLine("Stack is full. Cannot push.");
                return;
            }

            stackArray[++top] = nextValue++; // Increment top and push the next value
            Console.WriteLine($"Pushed: {stackArray[top]}");
        }

        //method for pop
        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty. Cannot pop.");
                return;
            }

            Console.WriteLine($"Popped: {stackArray[top--]}");
        }
    }
}
