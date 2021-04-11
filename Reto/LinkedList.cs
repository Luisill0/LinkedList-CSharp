using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    /**
     * Lista doblemente ligada
     */
    public class LinkedList<G> : List<G>
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
        internal class ForwardIterator : Iterator<G>
        {
            private Node<G> currentNode;

            public bool hasNext()
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

            public bool hasNext()
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

        /***
         * Inserts data at the end of the list
         * @param data Data to be inserted
        */
        public void add(G data)
        {
            Node<G> node = new Node<G>(data);
            node.previous = tail;

            if (tail != null)
            {
                tail.next = node;
            }

            if (head == null)
            {
                head = node;
            }

            tail = node;
            size++;
        }

        /***
         * @param index 0-index
         * @return data in index
        */
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

        /***
         * @param index 0-index
        */
        public void delete(int index)
        {
            Node<G> currentNode = head;
            int currentIndex = 0;

            if (index < 0 || index >= size)
            {
                return;
            }
            else
            {
                size--;
                if (size == 0)
                {
                    head = null;
                    tail = null;
                }else if(index == size)
                {
                    tail = tail.previous;
                    tail.next = null;
                }else if(index > 0 && index < size)
                {
                    while(currentIndex < index)
                    {
                        currentNode = currentNode.next;
                        currentIndex++;
                    }
                    currentNode.previous.next = currentNode.next;
                    currentNode.next.previous = currentNode.previous;
                }
            }
        }

        public Iterator<G> getForwardIterator()
        {
            ForwardIterator it = new ForwardIterator();
            it.setCurrentNode(head);
            return it;
        }

        public Iterator<G> getReverseIterator()
        {
            ReverseIterator it = new ReverseIterator();
            it.setCurrentNode(tail);
            return it;
        }

        public int getSize()
        {
            return size;
        }
    }
}
