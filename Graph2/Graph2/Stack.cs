using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph2
{
    public class Stack
    {
        private class Node //вложенный класс, реализующий элемент стека
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
        private Node head; //ссылка на вершину стека
        public Stack() //конструктор класса, создает пустой стек
        {
            head = null;
        }
        public void Push(object nodeInfo) // добавляет элемент в вершину стека
        {
            Node r = new Node(nodeInfo);
            r.Next = head;
            head = r;
        }
        public object Pop() //извлекает элемент из вершины стека, если он не пуст
        {
            if (head == null)

            {
                throw new Exception("Стек пуст");
            }
            else
            {
                Node r = head;
                head = r.Next;
                return r.Inf;
            }
        }
        public bool IsEmpty //определяет пуст или нет стек
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