using System;
namespace Фильтр
{
    class Program
    {
        static void Main(string[] args)
        {         
                Filtration<int> filter = new Filtration<int>(new int[] {-8, 14, 5, 4, 12, 19, -4, 17, -14});
                Predicate<int> pred = i => (i %2!=0 && i >= 10);

                filter.GetData();
                filter.GetData(pred);

                string[] names = new string[]{
      "Misha", "Sasha", "Bogdan", "Roman", "Zahar", "Alex", "Oleg", "Aleksey", "Sergay"
    };
                Filtration<string> filter2 = new Filtration<string>(names);
                string subj = "gay";
                Predicate<string> pred2 = str => str.IndexOf(subj) == -1;
                filter2.GetData(pred2);
            }
        }
    }
    

