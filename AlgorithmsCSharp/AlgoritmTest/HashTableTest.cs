using AlgorithmsCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmTest
{
    [TestClass]
    public class HashTableTest
    {
        private HashTable InsertItem()
        {
            HashTable hashTable = new HashTable();
            hashTable.populateDictionary(1, "A");
            hashTable.populateDictionary(2, "B");
            hashTable.populateDictionary(3, "C");
            hashTable.populateDictionary(4, "D");
            return hashTable;
        }


        [TestMethod]
        public void dictionaryCountTest()
        {
            HashTable hashTable = InsertItem();
            int count = hashTable.dictionaryCount();

            Assert.AreEqual(4, count);
        }

        [TestMethod]
        public void dictionaryPrintTest()
        {
            HashTable hashTable = InsertItem();
            string expected = "Chave: 1 Valor: A Chave: 2 Valor: B Chave: 3 Valor: C Chave: 4 Valor: D";
            string result = hashTable.printDictionary();

            Assert.AreEqual(expected, result);
        }
    }
}
