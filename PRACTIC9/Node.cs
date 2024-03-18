using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTIC9
{
    public class Node
    {
        public int key;
        public string value;
        public Node left;
        public Node right;

        public Node (int key,string value)
        {
            this.key = key;
            this.value = value;
            left = null;
            right = null;
        }
    }

    public class BinareTree
    {
        public Node root;

        public BinareTree()
        {
            root = null;
        }

        public void Put(int key,string value)
        {
            root = InsertRec(root,key,value);
        }
        private Node InsertRec(Node root,int key,string value)
        {
            if(root == null)
            {
                root = new Node(key,value);
                return root;
            }
            if(key < root.key)
            {
                root.left = InsertRec(root.left,key,value);
            }
            else
            {
                root.right = InsertRec(root.right,key,value);
            }

            return root;
        }
    }
}
