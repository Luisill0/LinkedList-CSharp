using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    public class ReverseIterator
    {
        private Node currentNode;

        public ReverseIterator(Node currentNode)
        {
            this.currentNode = currentNode;
        }

        public ReverseIterator(ReverseIterator reverseIterator)
        {
            currentNode = reverseIterator.currentNode;
        }

        public bool hasNext()
        {
            return currentNode != null;
        }

        public int next()
        {
            int data = currentNode.getData();
            currentNode = currentNode.getPrevious();
            return data;
        }

        public Node getCurrentNode()
        {
            return currentNode;
        }
    }
}
