using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary <string,string> dictionary= new Dictionary<string,string>();
            dictionary.Add("table", "tablo");
        }
    }
    class MyDictionary<T, V>
    {
        T[] array;
        T[] tempArray;
        V[] array2;
        V[] tempArray2;

        public MyDictionary()
        {
            array = new T[0];  
            array2= new V[0];
        }
        public void Add(V key, T item)
        {
            tempArray = array;
            tempArray2 = array2;

            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }

            for (int i = 0; i < tempArray2.Length; i++)
            {
                array2[i] = tempArray2[i];
            }
            array[array.Length - 1] = item;
            array2[array2.Length - 1] = key;
        }
        public int Length
        {
            get { return array.Length; }

        }


    }
}
