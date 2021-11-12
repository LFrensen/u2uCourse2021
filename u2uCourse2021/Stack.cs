using System;

namespace u2uCourse2021
{
    public class Stack
    {
        private static int capacity = 10;
        private string[] words = new string[capacity];
        private int index = 0;

        public void Push(string item)
        {
            if(index == words.Length)
            {
                Array.Resize(ref words, capacity *= 2);
                Console.WriteLine($"Changed capacity: {capacity}");
            }
            words[index++] = item;
            Console.WriteLine($"Added: {item}");
        }

        public string Pop()
        {
            if(index > 0)
            {
                return words[--index];
            }
            return "Can't pop";
        }
        public string Peek()
        {
            return index <= words.Length && index > 0 ? words[index-1] : "Can't peek";
        }
    }
}
