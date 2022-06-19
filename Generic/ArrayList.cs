using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class ArrayList<Template> : List<Template>
    {

        private Template[] array;
        private int start_size = 0;
        private int length;
        
        public int size()
        {
            return length;
        }

        public ArrayList()
        {
            array = new Template[start_size];
        }

        public ArrayList(int n)
        {
            array = new Template[n];
            length = n;
        }

        public void add(Template Typename)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = Typename;
                    return;
                }
            }

            if (length == 0)    length = 2;
            else                length *= 2;

            Template[] template = new Template[length];

            for (int i = 0; i < array.Length; i++)      template[i] = array[i];

            template[array.Length] = Typename;
            array = template;

            if (length == 0) length = 2;
            else length *= 2;

        }

        public void put(Template Typename, int position)
        {
            if (position >= length)           {Console.WriteLine("Array out of bounds"); return; }

            array[position] = Typename;
            
        }


        public void delete(int position)
        {
            Template[] template = new Template[length - 1];
            int k = 0;

            for(int i = 0; i< length; i++)
            {
                if (i != position)          template[k++] = array[i];

                array = template;
                length--;
            }
        }

        public int find(Template Typename)
        {
            for (int i = 0; i < length; i++)
            {
                if (array[i].Equals(Typename))      return i;
            }

            Console.WriteLine("404 : Elements not found");
            return -1;
        }

        public Template get(int i)
        {
            if (i < 0 || i >= length)          Console.WriteLine("Array out of bounds");

            return array[i];

        }

        
    }
}
