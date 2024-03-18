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
            
            public int Value { get; set; }
        }

        public class Tree
        {
            public int? Root { get; set; }

            private int size;

            public int Size
            {
                get { return size; }
            }

            public Tree()
            {
                Root = null;
            }
            public Tree(int val)
            {
                Root=val;
            }

            public void Put(int value)
            {
                if(Root > value)
                {

                }
            }

            
        }
    }
}
