using System;
using System.Collections.Generic;
using System.Text;

namespace Фильтр
{
    class Filtration<T>
    {
        private T[] data;

        public Filtration(T[] data)
        {
            this.data = data;
        }

        public T[] Filter(Predicate<T> predicate)
        {
            int counter = 0;
            T[] data1 = new T[data.Length], data2;

            foreach (var elem in data)
            {
                if (predicate(elem))
                {
                    data1[counter] = elem;
                    counter++;
                }
            }

            data2 = new T[counter];
            for (int i = 0; i < counter; ++i) data2[i] = data1[i];

            return data2;
        }

        public void GetData()
        {
            foreach (var elem in data) Console.Write($"{elem} ");
            Console.WriteLine();
        }

        public void GetData(Predicate<T> predicate)
        {
            foreach (var elem in Filter(predicate)) Console.Write($"{elem} ");
            Console.WriteLine();
        }
    }
}

