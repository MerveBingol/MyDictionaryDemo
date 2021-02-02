using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<S, Y> // Generic Class
    {

        S[] _array;
        S[] _tempArray;

        Y[] array;
        Y[] tempArray;



        public MyDictionary()
        {
            _array = new S[0];
            array = new Y[0];
        }

        public void Add(S sehir, Y yemek)
        {

            _tempArray = _array;
            tempArray = array;

            _array = new S[_array.Length + 1];
            array = new Y[array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
                array[i] = tempArray[i];
            }

            _array[_array.Length - 1] = sehir;
            array[array.Length - 1] = yemek;



        }
        public void Write()
        {

            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i] + " ---> " + array[i]);
            }

        }
    }
}

    
