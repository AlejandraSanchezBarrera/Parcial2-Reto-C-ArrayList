using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    interface Iterator<T>
    {
        Boolean hasNext();

        T next();
    }
}
