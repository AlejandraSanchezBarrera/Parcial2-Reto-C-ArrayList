using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    interface List<T>
    {
        void add(T data);

        T get(int index);

        void delete(int index);

        int getSize();

        Iterator<T> getIterator();

        Iterator<T> getReverseIterator();
    }
}
