using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTIC9
{
    internal class FIFOCollection
    {
        private string Value { get; set; }

        private int size = 0;

        private string [] QueueCustom = new string[0];

        public int Size
        {
            get { return size; }
        }
        public void Enque(string value)
        {
            if (isEmpty())
            {
                QueueCustom = new string[1];
                QueueCustom[0] = value;
                size++;
            }
            else
            {
                string[]temp = new string[QueueCustom.Length];
                for (int i = 0; i < QueueCustom.Length; i++)
                {
                    temp [i] = QueueCustom[i];
                }
                QueueCustom = new string[QueueCustom.Length + 1];
                for (int i = 0; i < temp.Length; i++)
                {
                    QueueCustom[i] = temp[i];
                }
                QueueCustom[QueueCustom.Length-1] = value;
                size++;
            }
        }
        public string Deque()
        {
            if (isEmpty())
            {
                return null;
            }
            else
            {
                string valueDeque = QueueCustom[0];
                string []temp = new string[QueueCustom.Length-1];
                for (int i = 1; i < QueueCustom.Length; i++)
                {
                    temp[i-1] = QueueCustom[i];
                }
                QueueCustom = new string[QueueCustom.Length - 1];
                for(int i = 0; i < temp.Length; i++)
                {
                    QueueCustom [i] = temp[i];
                }
                size--;
                return valueDeque;
            }
        }


        public bool isEmpty()
        {
            if (QueueCustom.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
