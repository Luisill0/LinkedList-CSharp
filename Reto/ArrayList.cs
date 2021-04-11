using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    public class ArrayList<G> : List<G> 
    {
        internal Object[] array;
        internal int size;

        public ArrayList()
        {
            this.array = new Object[2];
        }

        public void add(G data)
        {
            if (size == array.Length)
            {
                Object[] arrayAux = new Object[array.Length + 2];

                for(int i = 0; i < array.Length; i++)
                {
                    arrayAux[i] = array[i];
                }

                this.array = new Object[arrayAux.Length];

                for(int i = 0; i < array.Length; i++)
                {
                    array[i] = arrayAux[i];
                }
            }
            this.array[size] = data;
            size++;
        }

        public G get(int index)
        {
            return (G)array[index];
        }

        public void delete(int index)
        {
            for(int i = index; i < size-1; i++)
            {
                array[i] = array[i+1];
            }
            size--;
        }

        public int getSize()
        {
            return size;
        }

        public Iterator<G> getForwardIterator()
        {
            return new ForwardIterator(this);
        }

        public Iterator<G> getReverseIterator()
        {
            return new ReverseIterator(this);
        }

        public class ForwardIterator : Iterator<G>
        {
            private ArrayList<G> arrayList;
            private int currentIndex;

            public ForwardIterator(ArrayList<G> arrayList)
            {
                this.arrayList = arrayList;    
                this.currentIndex = 0;
            }

            public bool hasNext()
            {
                return currentIndex < arrayList.size;
            }

            public G next()
            {
                G data = (G)arrayList.array[currentIndex];
                currentIndex++;
                return data;
            }
        }

        public class ReverseIterator : Iterator<G>
        {
            private ArrayList<G> arrayList;
            private int currentIndex;

            public ReverseIterator(ArrayList<G> arrayList)
            {
                this.arrayList = arrayList;
                this.currentIndex = arrayList.size-1;
            }

            public bool hasNext()
            {
                return currentIndex >= 0;
            }

            public G next()
            {
                G data = (G)arrayList.array[currentIndex];
                currentIndex--;
                return data;
            }
        }
    }
}
