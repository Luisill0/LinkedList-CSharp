using System;

namespace Reto
{
    public class Main
    {
        public static void main(string[] args)
        {
            LinkedList lista1 = new LinkedList();

            lista1.add(1);
            lista1.add(4);
            lista1.add(3);
            lista1.add(7);

            Iterator it = lista1.getIterator();

            while (it.hasNext())
            {
                Iterator backupIt = new Iterator(it);
                int element = it.next();

                if (element == 3)
                {
                    lista1.insert(10, LinkedList.Position.BEFORE, backupIt);
                }

                if(element == 7)
                {
                    lista1.insert(15, LinkedList.Position.AFTER, backupIt);
                }
            }

            lista1.delete(3);

            Console.WriteLine("El tamaño es: {0}", lista1.getSize());
            Console.WriteLine("------------------------------------");

            it = lista1.getIterator();

            while (it.hasNext())
            {
                int element = it.next();
                Console.WriteLine("Dato: {0}", element);
            }

            Console.WriteLine("------------------------------------");

            ReverseIterator reverseIterator = lista1.getReverseIterator();

            while (reverseIterator.hasNext())
            {
                int element = reverseIterator.next();
                Console.WriteLine("Dato: {0}", element);
            }
            Console.WriteLine("------------------------------------");
        }
    }
}
