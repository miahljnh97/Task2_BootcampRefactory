using Task2;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTest
{
    public class Tests
    {
        Class1 unitTest;
        [SetUp]
        public void Setup()
        {
            unitTest = new Class1();
        }

        [Test]
        public void Test1()
        {
            var res1 = unitTest.Satu("saya");
            Assert.AreEqual(4, res1);
        }

        [Test]
        public void Test12()
        {
            var res12 = unitTest.Satu("lari pagi");
            Assert.AreEqual(9, res12);
        }

        [Test]
        public void Test2()
        {
            var res2 = unitTest.Dua(30);
            Assert.AreEqual("E", res2);
        }

        [Test]
        public void Test22()
        {
            var res22 = unitTest.Dua(75);
            Assert.AreEqual("C", res22);
        }

        [Test]
        public void Test3()
        {
            var res3 = unitTest.Tiga(43);
            Assert.AreEqual("Ganjil", res3);
        }

        [Test]
        public void Test32()
        {
            var res32 = unitTest.Tiga(1032);
            Assert.AreEqual("Genap", res32);
        }


        [Test]
        public void Test4()
        {
            var res4 = unitTest.Empat(1900);
            Assert.AreEqual("Bukan Kabisat", res4);
        }

        [Test]
        public void Test42()
        {
            var res42 = unitTest.Empat(2000);
            Assert.AreEqual("Kabisat", res42);
        }

        [Test]
        public void Test43()
        {
            var res43 = unitTest.Empat(2001);
            Assert.AreEqual("Bukan Kabisat", res43);
        }

        [Test]
        public void Test44()
        {
            var res44 = unitTest.Empat(2016);
            Assert.AreEqual("Kabisat", res44);
        }

        [Test]
        public void Test5()
        {
            var res5 = unitTest.Lima(15);
            Assert.AreEqual("Remaja", res5);
        }

        [Test]
        public void Test52()
        {
            var res52 = unitTest.Lima(32);
            Assert.AreEqual("Dewasa", res52);
        }

        [Test]
        public void Test6()
        {
            var res6 = unitTest.Enam(4,8);
            List<int> cekLisa = new List<int>{4, 5, 6, 7, 8};
            Assert.AreEqual(cekLisa, res6);
        }

        [Test]
        public void Test7()
        {
            var res7 = unitTest.Tujuh();
            List<int> cekLisa2 = new List<int> { 1, 3, 5 };
            Assert.AreEqual(cekLisa2, res7.Take(3));
        }

        [Test]
        public void Test8()
        {
            
           var res8 = unitTest.Delapan();
            List<string> cekLisa3 = new List<string> { "1. Ganjil", "2. Genap", "3. Ganjil" };
            Assert.AreEqual(cekLisa3, res8.Take(3));
        }

        [Test]
        public void Test9()
        {
            var res9 = unitTest.Sembilan("saya ingin makan nasi goreng");
            Assert.AreEqual("goreng nasi makan ingin saya", res9);
        }

        [Test]
        public void Test10()
        {
            string[] arr = { "Meja", "Buku", "Topi", "Baju", "Kayu" };
            string[] arr2 = { "Handuk", "Meja", "Buku", "Topi", "Baju", "Kayu", "Celana"};
            var res10 = unitTest.Sepuluh(arr , "Handuk", "Celana");
            Assert.AreEqual(arr2, res10);
        }
    }
}