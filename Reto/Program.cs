using System;

namespace Reto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list1 = new LinkedList<int>();
            List<string> list2 = new LinkedList<string>();

            list1.add(1);
            list1.add(4);
            list1.add(3);
            list1.add(10);
            list1.add(7);

            list2.add("hola");
            list2.add(" Object ");
            list2.add(" Oriented ");
            list2.add(" Programming ");

            list1.delete(3);

            Iterator<int> itInt = list1.getForwardIterator();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("LinkedList:\n");
            Console.WriteLine("El tamaño es: {0}", list1.getSize());

            while (itInt.hasNext())
            {
                int element = itInt.next();
                Console.WriteLine("Dato: {0}", element);
            }
            Console.WriteLine();

            itInt = list1.getReverseIterator();

            while (itInt.hasNext())
            {
                int element = itInt.next();
                Console.WriteLine("Dato: {0}", element);
            }

            Iterator<string> itString = list2.getForwardIterator();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("El tamaño es: {0}", list1.getSize());

            while (itString.hasNext())
            {
                string element = itString.next();
                Console.WriteLine("Dato: {0}", element);
            }
            Console.WriteLine();

            itString = list2.getReverseIterator();

            while (itString.hasNext())
            {
                string element = itString.next();
                Console.WriteLine("Dato: {0}", element);
            }
            Console.WriteLine("------------------------------------");

            list1 = new ArrayList<int>();
            list2 = new ArrayList<string>();

            list1.add(2);
            list1.add(6);
            list1.add(9);
            list1.add(17);
            list1.add(7);

            list2.add("hola");
            list2.add(" Object ");
            list2.add(" Oriented ");
            list2.add(" Programming ");

            list1.delete(2);

            itInt = list1.getForwardIterator();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("ArrayList:\n");
            Console.WriteLine("El tamaño es: {0}", list1.getSize());

            while (itInt.hasNext())
            {
                int element = itInt.next();
                Console.WriteLine("Dato: {0}", element);
            }
            Console.WriteLine();

            itInt = list1.getReverseIterator();

            while (itInt.hasNext())
            {
                int element = itInt.next();
                Console.WriteLine("Dato: {0}", element);
            }

            itString = list2.getForwardIterator();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("El tamaño es: {0}", list1.getSize());

            while (itString.hasNext())
            {
                string element = itString.next();
                Console.WriteLine("Dato: {0}", element);
            }
            Console.WriteLine();

            itString = list2.getReverseIterator();

            while (itString.hasNext())
            {
                string element = itString.next();
                Console.WriteLine("Dato: {0}", element);
            }
            Console.WriteLine("------------------------------------");
        }
    }
}
