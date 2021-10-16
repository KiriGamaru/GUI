using NUnit.Framework;
using GUI;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var a = GUI.GUI.Logic1.Answer(10,10,10,30,10,20);
            Assert.AreEqual("поезд сто€л на платформе, когда на неЄ пришЄл пассажир",a);
        }
        [Test]
        public void Test2()
        {
            var b = GUI.GUI.Logic1.Answer(10, 10, 10, 30, 10, 31);
            Assert.AreEqual("поезд Ќ≈ сто€л на платформе, когда на неЄ пришЄл пассажир", b);
        }
        [Test]
        public void Test3()
        {
            var a = GUI.GUI.Logic1.Answer(10, 10, 10, 30, 10, 10);
            Assert.AreEqual("поезд сто€л на платформе, когда на неЄ пришЄл пассажир", a);
        }
        [Test]
        public void Test4()
        {
            var a = GUI.GUI.Logic1.Answer(10, 10, 10, 30, 10, 30);
            Assert.AreEqual("поезд сто€л на платформе, когда на неЄ пришЄл пассажир", a);
        }
        [Test]
        public void Test5()
        {
            var a = GUI.GUI.Logic1.Answer(10, 10, 10, 30, 10, 01);
            Assert.AreEqual("поезд Ќ≈ сто€л на платформе, когда на неЄ пришЄл пассажир", a);
        }
        [Test]
        public void Test6()
        {
            var a = GUI.GUI.Logic1.Answer(10, 10, 10, 30, 10, 30);
            Assert.AreEqual("поезд сто€л на платформе, когда на неЄ пришЄл пассажир", a);
        }
        [Test]
        public void Test7()
        {
            var a = GUI.GUI.Logic1.Answer(200, 00, 24, 20, 00, 60);
            Assert.AreEqual("введЄнные данные не удовлетвор€ют условию задачи", a);
        }
        [Test]
        public void Test8()
        {
            var c = GUI.GUI.Logic2a.AnA(1000,23);
            Assert.AreEqual("величина ежемес€чного увеличени€ вклада превысит 23 руб. за 9 мес€ца(ев)", c);
        }
        [Test]
        public void Test9()
        {
            var d = GUI.GUI.Logic2b.AnB(1000, 1200);
            Assert.AreEqual("размер вклада превысит 1200 руб. за 10 мес€ца(ев)", d);
        }
        [Test]
        public void Test10()
        {
            var c = GUI.GUI.Logic2a.AnA(1000, 1);
            Assert.AreEqual("величина ежемес€чного увеличени€ вклада превысит 1 руб. за 1 мес€ца(ев)", c);
        }
        [Test]
        public void Test11()
        {
            var d = GUI.GUI.Logic2b.AnB(1000, 900);
            Assert.AreEqual("размер вклада превысит 900 руб. за 0 мес€ца(ев)", d);
        }
    }
}