using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista1 = new ArrayList<int>();
            List<string> lista2 = new ArrayList<string>();

            lista1.add(1);
            lista1.add(4);
            lista1.add(3);
            lista1.add(7);

            lista2.add("Hola");
            lista2.add("Object ");
            lista2.add("Oriented ");
            lista2.add("Programming ");

            lista1.delete(3);

            Console.WriteLine("................");
            Console.WriteLine("   ArrayList");
            Console.WriteLine("................");

            Console.WriteLine("----------------");
            Console.WriteLine("El tamaño es:" + lista1.getSize());
            Console.WriteLine("----------------");

            Iterator<int> it = lista1.getIterator();

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: " + element);
            }

            Console.WriteLine("----------------");

            it = lista1.getReverseIterator();

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: " + element);
            }

            Console.WriteLine("----------------");

            Iterator<string> itStrings = lista2.getIterator();

            while (itStrings.hasNext())
            {
                Console.WriteLine(itStrings.next());
            }

///-------------------------------------------------------------------------------------------

            List<int> lista3 = new LinkedList<int>();
            List<string> lista4 = new LinkedList<string>();

            lista3.add(8);
            lista3.add(9);
            lista3.add(7);
            lista3.add(2);

            lista4.add("Hola");
            lista4.add("Linked ");
            lista4.add("List ");
            lista4.add("C# ");

            lista3.delete(9);

            it = lista3.getIterator();

            Console.WriteLine("\n\n................");
            Console.WriteLine("   LinkedList");
            Console.WriteLine("................");

            Console.WriteLine("----------------");
            Console.WriteLine("El tamaño es:" + lista3.getSize());
            Console.WriteLine("----------------");

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: " + element);
            }

            Console.WriteLine("----------------");

            it = lista3.getReverseIterator();

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: " + element);
            }

            Console.WriteLine("----------------");

            itStrings = lista4.getIterator();

            while (itStrings.hasNext())
            {
                Console.WriteLine(itStrings.next());
            }

            Console.ReadKey();
        }
    }
}
