using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class LinkedList<Template> : List<Template>
    {

        public class Node<variable>
        {
            public Node<variable> first = null;
            public Node<variable> next = null;
            public variable give;
        }

        private Node<Template> node;

        public LinkedList()
        {
            node = null;
        }

        public void add(Template Typename)
        {
            if (node == null)
            {
                node = new Node<Template>();
                node.give = Typename;
            }
            else
            {
                Node<Template> template = node;

                while (template.next != null)
                {
                    template = template.next;
                }

                template.next = new Node<Template>();
                template.next.first = template;
                template.next.give = Typename;
            }
        }

        public void put(Template Typename, int position)
        {
            Node<Template> template = node;
            
            if (position == 0)
            {
                node = new Node<Template>();
                node.next = template;
                node.give = Typename;
                template.first = node;
                return;
            }

            int k = 0;

            while ( k < position)
            {
                if (template.next == null)          {Console.WriteLine("Error");return;}
                template = template.next;
                k++;
            }

            Node<Template> next = template;
            template = new Node<Template>();
            template.first = next.first;
            template.next = next;
            template.give = Typename;
            next.first.next = template;
        }


        public void delete(int position)
        {
            Node<Template> template = node;

            for(int i = 0; i < position; i++)
            {
                if (template.next == null)          {Console.WriteLine("Error delete"); return;}
                template = template.next;

                if (template.next != null)          template.first.next = template.next;
                else                                template.first.next = null;
            }
        }

        public int find(Template Typename)
        {
            Node<Template> template = node;
            int k = 0;

            while (template != null && template.Equals(Typename))
            {
                template = template.next;
                k++;
            }

            if (template == null)           return -1;
            return k;
        }

        public Template get(int index)
        {
            Node<Template> template = node;

            for(int i = 0; i < index; i++)
            {
                if(template.next == null)           {Console.WriteLine("Error remove"); break;}
                template = template.next;

            }

            return template.give;
        }

    }
}
