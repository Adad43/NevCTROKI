using System;

namespace Работа_со_строками
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello world !";
            string s2 = "world";
            
            if (String.Compare(s1, s2) < 0)
                Console.WriteLine("Строка s1 перед строкой s2");

            else if (String.Compare(s1, s2) > 0)
                Console.WriteLine("Строка s1 стоит после строки s2");

            else if (String.CompareOrdinal(s1, s2) == 0)
                Console.WriteLine("Строки s1 и s2 одинаковы");

            else if (String.CompareOrdinal(s1, s2) != 0)
                Console.WriteLine("Строки s1 и s2 не равны");

            else if (s2.IndexOf("world") != -1)
                Console.WriteLine("Слово \"world\" найдено в строке, оно " +
                "находится на: {0} позиции", s2.IndexOf("world"));

            byte value1 = 12;
            int value2 = 12;

            object object1 = value1;
            object object2 = value2;

            Console.WriteLine("{0} ({1}) = {2} ({3}): {4}",
            object1, object1.GetType().Name,
            object2, object2.GetType().Name,
            object1.Equals(object2));

            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' находится в строке '{1}': {2}",
            s2, s1, b);
            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine("'{0} Данное слово встречается на позиций {1}",
                    s2, index + 1);
            }
            Console.ReadLine();
        }
    }
}
