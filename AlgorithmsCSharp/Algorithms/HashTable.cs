using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCSharp
{
    public class HashTable
    {
        private Dictionary<dynamic, dynamic> items;

        public HashTable()
        {
            items = new Dictionary<dynamic, dynamic>();
        }

        public void populateDictionary(dynamic key, dynamic value)
        {
            items.Add(key, value);
        }

        public void replaceDictionaryItem(dynamic key, dynamic value)
        {
            items[key] = value;
        }

        public string printDictionary()
        {
            string dictionary = $"";

            foreach(var item in items)
            {
                dictionary += $"Chave: {item.Key } Valor: {item.Value} ";
            }

            return dictionary.Trim();
        }

        public int dictionaryCount()
        {
            return items.Count;
        }
    }
}
