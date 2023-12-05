using System;

namespace ClassStack
{
    class Program
    {
        static void Main()
        {
            Stack stack1 = new Stack(5);
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Print();
            stack1.Peek();
            Console.WriteLine($"Среднее значение: {stack1.GetAverage()}");

            int removedValue = stack1.Pop();
            Console.WriteLine($"Удаленный элемент: {removedValue}");

            Stack stack2 = new Stack(stack1);
            stack2.Pop();
            stack2.Print();
            stack2.Peek();
            Console.WriteLine($"Среднее значение: {stack2.GetAverage()}");
        }
    }
}