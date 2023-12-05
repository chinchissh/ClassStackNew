using System;

namespace ClassStack
{
    class Stack
    {
        private class Node
        {
            public int Value;
            public Node Next;

            public Node(int value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node top;
        private int size;
        private int maxSize;
        private int sum;

        public Stack(int maxSize)
        {
            this.maxSize = maxSize;
            size = 0;
            top = null;
            sum = 0;
        }

        public Stack(Stack otherStack)
        {
            maxSize = otherStack.maxSize;
            size = 0;
            top = null;
            sum = 0;

            Node current = otherStack.top;
            while (current != null)
            {
                Push(current.Value);
                current = current.Next;
            }
        }

        public bool IsFull()
        {
            return size >= maxSize;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Push(int value)
        {
            if (!IsFull())
            {
                Node newNode = new Node(value);
                newNode.Next = top;
                top = newNode;
                size++;
                sum += value;
                Console.WriteLine($"Добавлен: {value}");
            }
            else
            {
                Console.WriteLine("Стек переполнен. Невозможно добавить элемент.");
            }
        }

        public int Pop()
        {
            if (!IsEmpty())
            {
                int removedValue = top.Value;
                top = top.Next;
                size--;
                sum -= removedValue;
                Console.WriteLine($"Удален: {removedValue}");
                return removedValue;
            }
            else
            {
                Console.WriteLine("Стек пуст. Невозможно удалить элемент.");
                return -1; // Возвращаем специальное значение для обозначения ошибки
            }
        }

        public void Peek()
        {
            if (!IsEmpty())
            {
                int topValue = top.Value;
                Console.WriteLine($"Верхний элемент стека: {topValue}");
            }
            else
            {
                Console.WriteLine("Стек пуст. Нет элементов для просмотра.");
            }
        }

        public void Print()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Элементы стека:");
                Node current = top;
                while (current != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Next;
                }
            }
            else
            {
                Console.WriteLine("Стек пуст. Нет элементов для вывода.");
            }
        }

        public double GetAverage()
        {
            if (!IsEmpty())
            {
                return (double)sum / size;
            }
            else
            {
                Console.WriteLine("Стек пуст. Нет элементов для вычисления среднего значения.");
                return 0;
            }
        }
    }
}