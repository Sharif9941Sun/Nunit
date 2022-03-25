using NUnit.Framework;
using System;
using System.Diagnostics;

namespace Calc___Nunit
{
    public class Tests
    {
        /*
        [SetUp]
        public void Setup()
        {
        }
        */

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        Random rnd = new Random();

        [TestCase]
        public void Addition()
        {

            float a = rnd.Next(-100, 100) / 10;
            float b = rnd.Next(-100, 100) / 10;

            Assert.AreEqual(Calculation.Add(a, b), (a + b));
        }

        [TestCase]
        public void Subtraction()
        {
            float a = rnd.Next(-100, 100) / 10;
            float b = rnd.Next(-100, 100) / 10;

            Assert.AreEqual(Calculation.Subract(a, b), (a - b));
        }

        [Test]
        public void Multiplication()
        {
            float a = rnd.Next(-100, 100) / 10;
            float b = rnd.Next(-100, 100) / 10;

            Assert.AreEqual(Calculation.Multiply(a, b), (a * b));
        }

        [Test]
        public void Division()
        {
            float a = rnd.Next(-100, 100) / 10;
            float b = rnd.Next(-100, 100) / 10;

            Debug.WriteLine("Hello World");
            Assert.AreEqual(Calculation.Divide(a, b), (a / b));
        }

        [Test]
        public void Error()
        {
            Debug.WriteLine("This is Error Method");
            Assert.AreEqual(0, 1, "Message 123");
        }
    }
}