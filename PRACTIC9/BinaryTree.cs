using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTIC9
{
    public class BinaryTree
    {
        public class BinaryNode
        {
            public BinaryNode? Left { get; set; } = null;
            public BinaryNode? Right { get; set; } = null ;
            
            public string Value { get; set; } 
            public int Key { get; set; }
        }

        public class Tree
        {

            BinaryNode node = new BinaryNode();

            private int size;

            public int Size
            {
                get { return size; }
            }
            public Tree(int key,string value)
            {
                node.Value = value;
                node.Key = key;
            }

            public void Put(int key,string value)
            {
                while (true)
                {
                    if (node.Key >= key)
                    {
                        node.Right = new BinaryNode();
                        node.Right.Value = value;
                        node.Key = key;
                        return;
                    }
                    else
                    {
                        node.Left = new BinaryNode();
                        node.Left.Value = value;
                        node.Key = key;
                        return;
                    }
                }
            }

            
        }
    }
}
