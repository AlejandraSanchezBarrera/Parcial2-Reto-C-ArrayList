using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class LinkedList<G> : List<G>
    {
        public class Node<T>
        {
            internal readonly T data;
            internal Node<T> previous;
            internal Node<T> next;

            public Node(T data)
            {
                this.data = data;
            }
        }
        
        private Node<G> head;
        private Node<G> tail;
        private int size;
        private static int listsCount = 0;

        public LinkedList()
        {
            listsCount++;
        }

        public static int getListsCount()
        {
            return listsCount;
        }

        internal class ForwardIterator : Iterator<G>
        {
            private Node<G> currentNode;

            public Boolean hasNext()
            {
                return currentNode != null;
            }

            public G next()
            {
                G data = currentNode.data;
                currentNode = currentNode.next;
                return data;
            }

            Node<G> getCurrentNode()
            {
                return currentNode;
            }

            public void setCurrentNode(Node<G> currentNode)
            {
                this.currentNode = currentNode;
            }
        }

        public class ReverseIterator : Iterator<G>
        {
            private Node<G> currentNode;

            public Boolean hasNext()
            {
                return currentNode != null;
            }

            public G next()
            {
                G data = currentNode.data;
                currentNode = currentNode.previous;
                return data;
            }

            public void setCurrentNode(Node<G> currentNode)
            {
                this.currentNode = currentNode;
            }
            
            Node<G> getCurrentNode()
            {
                return currentNode;
            }
        }

        public void add(G data)
        {
            Node<G> node = new Node<G>(data);
            node.previous = tail;

            if (tail != null)
            {
                tail.next = node;
            }

            if(head==null)
            {
                head = node;
            }

            tail = node;
            size ++;
        }

        public void delete(int index)
        {
            Node<G> currentNode = head;
            int currentIndex = 0;

            if(index<0 || index >= size)
            {
                return;
            }

            size--;

            if (size == 0)
            {
                head = null;
                tail = null;
            }

            if (index == 0)
            {
                head = head.next;
                head.previous = null;
            }

            if (index == size)
            {
                tail = tail.previous;
                tail.next = null;
            }

            if(index>0 && index < size)
            {
                while (currentIndex < index)
                {
                    currentNode = currentNode.next;
                    currentIndex++;
                }
                currentNode.previous.next = currentNode.next;
                currentNode.next.previous = currentNode.previous;
            }
        }

        public G get(int index)
        {
            Node<G> currentNode = head;
            int currentIndex = 0;

            while (currentIndex < index)
            {
                currentNode = currentNode.next;
                currentIndex++;
            }

            return currentNode.data;
        }

        public Iterator<G> getIterator()
        {
            ForwardIterator iterator = new ForwardIterator();
            iterator.setCurrentNode(head);
            return iterator;
        }

        public Iterator<G> getReverseIterator()
        {
            ReverseIterator iterator = new ReverseIterator();
            iterator.setCurrentNode(tail);
            return iterator;
        }

        public int getSize()
        {
            return size;
        }
    }
}
