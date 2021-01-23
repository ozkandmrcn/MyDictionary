using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        public K[] keys;
        public V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];

        }

        public void Add(K key, V value)
        {
            K[] temporaryKeys = keys;
            V[] temporaryValues = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < temporaryKeys.Length; i++)
            {
                keys[i] = temporaryKeys[i];
                values[i] = temporaryValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
    }
}