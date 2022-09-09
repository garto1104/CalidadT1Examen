using NUnit.Framework;
using CalidadT1;

namespace TestCalidadT1.Tests
{
    public class AlgortimosTests
    {
        [Test]
        public void Test1()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(1);
            Assert.AreEqual("I", resp);
        }  
        [Test]
        public void Test2()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(2);
            Assert.AreEqual("II", resp);
        }
        [Test]
        public void Test3()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(3);
            Assert.AreEqual("III", resp);
        }
        [Test]
        public void Test4()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(66);
            Assert.AreEqual("LXVI", resp);
        }
        [Test]
        public void Test5()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(5);
            Assert.AreEqual("V", resp);
        }
        [Test]
        public void Test6()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(6);
            Assert.AreEqual("VI", resp);
        }
        [Test]
        public void Test7()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(7);
            Assert.AreEqual("VII", resp);
        }
        [Test]
        public void Test8()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(8);
            Assert.AreEqual("VIII", resp);
        }
        [Test]
        public void Test9()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(105);
            Assert.AreEqual("CV", resp);
        }
        [Test]
        public void Test10()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(10);
            Assert.AreEqual("X", resp);
        }
        [Test]
        public void Test11()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(122);
            Assert.AreEqual("CXXII", resp);
        }
        [Test]
        public void Test12()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(15);
            Assert.AreEqual("XV", resp);
        }
        [Test]
        public void Test13()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(125);
            Assert.AreEqual("CXXV", resp);
        }
        [Test]
        public void Test14()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(80);
            Assert.AreEqual("LXXX", resp);
        }
        [Test]
        public void Test15()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(15);
            Assert.AreEqual("XV", resp);
        }
        [Test]
        public void Test16()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(16);
            Assert.AreEqual("XVI", resp);
        }
        [Test]
        public void Test17()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(501);
            Assert.AreEqual("DI", resp);
        }
        [Test]
        public void Test18()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(18);
            Assert.AreEqual("XVIII", resp);
        }
        [Test]
        public void Test19()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(53);
            Assert.AreEqual("LIII", resp);
        }
        [Test]
        public void Test20()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(37);
            Assert.AreEqual("XXXVII", resp);
        }
        [Test]
        public void Test21()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(130);
            Assert.AreEqual("CXXX", resp);
        }
        [Test]
        public void Test22()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(110);
            Assert.AreEqual("CX", resp);
        }
        [Test]
        public void Test23()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(86);
            Assert.AreEqual("LXXXVI", resp);
        }
        [Test]
        public void Test24()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(280);
            Assert.AreEqual("CCLXXX", resp);
        }
        [Test]
        public void Test25()
        {
            var romanoGenerator = new RomanoGenerator();
            var resp = romanoGenerator.GetRomano(100);
            Assert.AreEqual("C", resp);
        }
    }
}