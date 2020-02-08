using AlgorithmsCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AlgoritmTest
{
    [TestClass]
    public class LinkedListTest
    {
        
        private LinkedList InsertItem()
        {
            LinkedList itemlist = new LinkedList();
            itemlist.insert(38);
            itemlist.insert(49);
            itemlist.insert(13);
            itemlist.insert(15);
            return itemlist;
        }

        [TestMethod]
        public void GetCountTest()
        {
            LinkedList itemlist = InsertItem();
            int count = itemlist.get_count();

            Assert.AreEqual(4, count);
        }

        [TestMethod]
        public void ItemFindTest()
        {
            LinkedList itemlist = InsertItem();
            Node item = itemlist.find(13);

            Assert.AreEqual(13, item.Val);

            Node item2 = itemlist.find(78);

            Assert.AreEqual(null, item2);
        }

        [TestMethod]
        public void DeleteItemTest()
        {
            LinkedList itemlist = InsertItem();
            int count = itemlist.get_count();
            Assert.AreEqual(4, count);
            itemlist.deleteAt(3);
            int count2 = itemlist.get_count();
            Assert.AreEqual(3, count2);
            Node item = itemlist.find(38);
            Assert.AreEqual(null, item);
        }
    }
}
