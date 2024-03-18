using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTIC9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomDictionary dict = new CustomDictionary();
            #region oldTest
            /*
            dict.Put("key1", "value1");
            dict.Put("key2", "value2");

            Console.WriteLine(dict.Size);
            Console.WriteLine($"Key 1 = {dict.Get("key1")}");
            Console.WriteLine($"Key 2 = {dict.Get("key2")}");
            Console.ReadLine(); */
            #endregion
            #region twoElements
            /*
            dict.Put("key1", "value1");
            dict.Put("key2", "value2");
            */
            #endregion
            #region CustomDictionary
            /*
            for (var i = 0; i < 100; i++)
            {
                dict.Put($"key{i}", $"value{i}");
            }   
            Console.WriteLine(dict);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(dict.Get("key4"));
            dict.Remove("key94");
            dict.Remove("key48");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(dict);
            */
            #endregion
            #region FIFO
            /*
            Queue<string> queue = new Queue<string>();
            FIFOCollection fifo = new FIFOCollection();
            Console.WriteLine(fifo.Size);
            queue.Enqueue("Key1q");
            queue.Enqueue("Key2q");
            queue.Enqueue("Key3q");
            queue.Enqueue("Key4q");
            fifo.Enque("Key1");
            fifo.Enque("Key2");
            fifo.Enque("Key3");
            fifo.Enque("Key4");
            Console.WriteLine(fifo.Size);
            Console.WriteLine(queue.Count);
            Console.WriteLine(fifo.Deque());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(fifo.Deque());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(fifo.Deque());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(fifo.Deque());
            */
            #endregion
            BinaryTree.Tree tree = new BinaryTree.Tree(50,"test1");
            tree.Put(30, "тест2");
            tree.Put(60, "тест3");
            tree.Put(20, "тест4");
            tree.Put(70, "тест5");
            Console.ReadLine();

        }
    }
}
