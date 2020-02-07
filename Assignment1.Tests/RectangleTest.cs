using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Assignment1.Tests
{
    [TestFixture]
    public class RectangleTest
    {
        [SetUp]
        public void Setup()
        {
            Rectangle rectangle = new Rectangle();
        }

        [Test]
        public void Input1_GetLength_Output1()
        {

            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(1, rectangle.GetLength(), 0);
        }

        [Test]
        public void Input2_GetLength_Output2()
        {

            Rectangle rectangle = new Rectangle(2, 1);
            Assert.AreEqual(2, rectangle.GetLength(), 0);
        }

        [Test]
        public void Input3_GetLength_Output3()
        {

            Rectangle rectangle = new Rectangle(3,1);
            Assert.AreEqual(3, rectangle.GetLength(), 0);
        }


        [Test]
        public void Input1_SetLength_Output1()
        {
            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(5, rectangle.SetLength(5), 0);
        }

        [Test]
        public void Input2_SetLength_Output2()
        {
            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(4, rectangle.SetLength(4), 0);
        }

        [Test]
        public void Input3_SetLength_Output3()
        {
            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(6, rectangle.SetLength(6), 0);
        }

        [Test]
        public void Input1_GetWidth_Output1()
        {
            Rectangle rectangle = new Rectangle(1, 12);
            Assert.AreEqual(12, rectangle.GetWidth(), 0);
        }

        [Test]
        public void Input2_GetWidth_Output2()
        {
            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(1, rectangle.GetWidth(), 0);
        }

        [Test]
        public void Input3_GetWidth_Output3()
        {
            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(1, rectangle.GetWidth(), 0);
        }

        [Test]
        public void Input1_SetWidth_Output()
        {
            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(2, rectangle.SetWidth(2), 0);
        }


        [Test]
        public void Input2_SetWidth_Output2()
        {
            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(6, rectangle.SetWidth(6), 0);
        }

        [Test]
        public void Input3_SetWidth_Output3()
        {
            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(18, rectangle.SetWidth(18), 0);
        }

        [Test]
        public void Input1_GetArea_Output1()
        {
            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(1, rectangle.GetArea(), 0);
        }

        [Test]
        public void Input2_GetArea_Output2()
        {
            Rectangle rectangle = new Rectangle(3,4);
            Assert.AreEqual(12, rectangle.GetArea(), 0);
        }

        [Test]
        public void Input3_GetArea_Output3()
        {
            Rectangle rectangle = new Rectangle(12,5);
            Assert.AreEqual(60, rectangle.GetArea(), 0);
        }
        [Test]
        public void Input1_GetPerimeter_Output2()
        {
            Rectangle rectangle = new Rectangle(1,1);
            Assert.AreEqual(4, rectangle.GetPerimeter(), 0);
        }

        [Test]
        public void Input2_GetPerimeter_Output2()
        {
            Rectangle rectangle = new Rectangle(3, 4);
            Assert.AreEqual(14, rectangle.GetPerimeter(), 0);
        }

        [Test]
        public void Input3_GetPerimeter_Output3()
        {
            Rectangle rectangle = new Rectangle(5, 7);
            Assert.AreEqual(24, rectangle.GetPerimeter(), 0);
        }
    }
}
