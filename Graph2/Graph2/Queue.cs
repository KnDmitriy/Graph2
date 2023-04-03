using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph2
{
    public class Queue
    {
        private class Node //вложенный класс, реализующий базовый элемент очереди

        {
            private object inf;
            private Node next;
            public Node(object nodeInfo)
            {
                inf = nodeInfo;
                next = null;
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            public object Inf
            {
                get { return inf; }
                set { inf = value; }
            }
        } //конец класса Node
        private Node head;
        private Node tail;
        public Queue()
        {
            head = null;
            tail = null;
        }
        public void Add(object nodeInfo)
        {
            Node r = new Node(nodeInfo);
            if (head == null)
            {
                head = r;
                tail = r;
            }
            else
            {
                tail.Next = r;
                tail = r;
            }
        }
        public object Take()
        {
            if (head == null)
            {
                throw new Exception("Очередь пуста.");
            }
            else
            {
                Node r = head;
                head = head.Next;

                if (head == null)
                {
                    tail = null;
                }
                return r.Inf;
            }
        }
        public bool IsEmpty
        {
            get
            {
                if (head == null)
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
}