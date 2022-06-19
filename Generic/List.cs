using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public interface List<Template>
    {
        public abstract void add(Template Typename);
        public abstract void put(Template Typename, int position);
        public abstract void delete(int position);
        public abstract int find(Template Typename);
        public abstract Template get(int index);
    }
}
