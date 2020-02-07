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
        public void Input1_SetLength_Output()
        {
            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(2, rectangle.SetLength(2), 0);
        }

        
    }
}
