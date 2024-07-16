using Microsoft.VisualStudio.TestTools.UnitTesting;
using skillTestVillon.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skillTestVillon.TestCases
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void BubbleSort_SortsCorrectly()
        {
         
            var strategy = new BubbleSortStrategy();
            string input = "befdac";
            string expected = "abcdef";

          
            string result = strategy.Sort(input);

     
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void QuickSort_SortsCorrectly()
        {
            var strategy = new QuickSortStrategy();
            string input = "befdac";
            string expected = "abcdef";

            string result = strategy.Sort(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MergeSort_SortsCorrectly()
        {

            var strategy = new MergeSortStrategy();
            string input = "befdac";
            string expected = "abcdef";

            string result = strategy.Sort(input);

         
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SortContext_UsesCorrectStrategy()
        {
         
            var context = new SortContext();
            context.SetSortStrategy(new BubbleSortStrategy());
            string input = "befdac";
            string expected = "abcdef";


            string result = context.Sort(input);

         
            Assert.AreEqual(expected, result);

  
            context.SetSortStrategy(new QuickSortStrategy());
            result = context.Sort(input);

            Assert.AreEqual(expected, result);

           
            context.SetSortStrategy(new MergeSortStrategy());
            result = context.Sort(input);

        
            Assert.AreEqual(expected, result);
        }
    }
}
