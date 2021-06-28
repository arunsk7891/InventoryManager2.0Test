using NUnit.Framework;
using System;
using System.IO;

namespace InvetroyManagerTest
{
    public class Tests
    { // Test Setup 
        private const string Expected = "Hello World";
        [SetUp]
        public void Setup()
        {
        }
        // Test 
        [Test]
        public void Test1()
        {
            //Assert.Pass();

            using (var sw = new StringWriter())
            {

                Console.SetOut(sw);
                string[] items = new string[] { "Shirt", "Cake", "Orange" };
                InventoryManager.Program.Main(items);

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);



            }

        }
    }
}