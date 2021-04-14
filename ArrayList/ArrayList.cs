using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class ArrayList<H> : List<H>
    {
        internal Object[] array;
        internal int size;

        public ArrayList()
        {
            this.array = new Object[2];
        }

        public void add(H data)
        {
            if (size == array.Length)
            {
                Object[] aux = new Object[array.Length + 2];

                for(int i=0;i<array.Length;i++)
                {
                    aux[i] = array[i];
                }

                this.array = new Object[aux.Length];

                for(int i=0;i<array.Length;i++)
                {
                    array[i] = aux[i];
                }
            }
            this.array[size] = data;
            size++;
        }

        public void delete(int index)
        {
            if (index < 0 || index >= size)
                return;

            for (int i = index + 1; i < size; i++)
                this.array[i - 1] = this.array[i];

            size--;
        }

        public H get(int index)
        {
            return (H)array[index];
        }

        public Iterator<H> getIterator()
        {
            return new ForwardIterator(this);
        }

        public Iterator<H> getReverseIterator()
        {
            return new ReverseIterator(this);
        }

        public int getSize()
        {
            return size;
        }

        public void insert(H data, Position position, Iterator<H> it) { }

        public class ForwardIterator : Iterator<H>
        {
            private ArrayList<H> arrayList;
            private int position;

            public ForwardIterator(ArrayList<H> arrayList)
            {
                this.arrayList = arrayList;
                this.position = 0;
            }

            public ForwardIterator(int position)
            {
                this.position = position;
            }

            public bool hasNext()
            {
                return position <arrayList.size;
            }

            public H next()
            {
                H data = (H)arrayList.array[position];
                position++;
                return data;
            }
        }

        public class ReverseIterator : Iterator<H>
        {
            private ArrayList<H> arrayList;
            private int position;

            public ReverseIterator(ArrayList<H> arrayList)
            {
                this.arrayList = arrayList;
                this.position = arrayList.size- 1;
            }

            public ReverseIterator(int position)
            {
                this.position = position;
            }

            public bool hasNext()
            {
                return position >= 0;
            }

            public H next()
            {
                H data = (H)arrayList.array[position];
                position--;
                return data;
            }
        }
    }
}
