using System;
using System.Collections.Generic;
using System.Text;

namespace DictonaryGenerics
{
    class MyDictonary<K,V>
    {
        K[] _keyArray;
        V[] _valueArray;

        //create contructor
        public MyDictonary()
        {
            _keyArray = new K[0];
            _valueArray = new V[0];
        }

        public void Add(K key , V value)
        {
            K[] tempKeyArray = _keyArray;
            V[] tempValueArray = _valueArray;

            _keyArray = new K[_keyArray.Length + 1];
            _valueArray = new V[_valueArray.Length + 1];

            // for loop with key
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                _keyArray[i] = tempKeyArray[i]; 
            }
            _keyArray[_keyArray.Length - 1] = key;

            //for loop with value
            for (int j = 0; j < tempValueArray.Length; j++)
            {
                _valueArray[j] = tempValueArray[j];
            }
            _valueArray[_valueArray.Length - 1] = value;
        }

    }
}
