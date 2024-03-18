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
            
            public string value { get; set; } 
            public int key { get; set; }
        }

        public class Tree:BinaryNode
        {

            BinaryNode Root { get; set; }

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
                
            }

            public void Put(int key,string value)
            {
                if(Root.value == null)
                {
                    Root.key = key;
                }

            }

            
        }
    }
}
