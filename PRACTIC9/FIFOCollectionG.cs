using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PRACTIC9
{
    internal class FIFOCollectionG
    {
        private string value { get; set; }

        private int size;

        private string[] QueueCustom = new string[20];
        private int cursorstart = 0;
        private int cursorend = 0;

        public int Size
        {
            get { return size; }
        }
        public void Enque(string value)
        {
            if(cursorend == QueueCustom.Length)
            {
                //увеличить масив
            }
            QueueCustom[cursorend] = value;
            size++;
            cursorend++;
        }
        public string Deque()
        {
            string temp = QueueCustom[cursorstart];
            QueueCustom[cursorstart] = null;
            cursorstart++;
            size--;
            return temp;
        }
    }
}
