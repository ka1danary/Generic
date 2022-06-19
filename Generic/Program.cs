using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> array = new ArrayList<int>();
            Console.WriteLine(array.size());
            array.add(50);
            Console.WriteLine(array.size());
            Console.WriteLine(array.size());
            Console.WriteLine(array.get(0));
           
            array.put(1, 1);
            Console.WriteLine(array.get(1));

            LinkedList<int> linked = new LinkedList<int>();
            linked.add(22);
            Console.WriteLine(linked.get(0));
            Console.WriteLine(linked.find(22));
            
            

        }
    }
}
