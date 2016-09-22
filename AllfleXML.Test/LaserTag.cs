﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllfleXML.Test
{
    [TestClass]
    public class LaserTag
    {
        [TestMethod]
        public void ImportLaserTag1()
        {
            var order = AllfleXML.LaserTag.Parser.Import(@"TestData\LaserTag\sample1.xml");
            Assert.IsNotNull(order);
            Assert.IsTrue(order.Any());
        }

        [TestMethod]
        public void ImportLaserTag2()
        {
            var order = AllfleXML.LaserTag.Parser.Import(@"TestData\LaserTag\sample2.xml");
            Assert.IsNotNull(order);
            Assert.IsTrue(order.Any());
        }

        [TestMethod]
        public void ImportLaserTag3()
        {
            var order = AllfleXML.LaserTag.Parser.Import(@"TestData\LaserTag\sample3.xml");
            Assert.IsNotNull(order);
            Assert.IsTrue(order.Any());
        }

        [TestMethod]
        public void ImportLaserTag4()
        {
            var order = AllfleXML.LaserTag.Parser.Import(@"TestData\LaserTag\sample4.xml");
            Assert.IsNotNull(order);
            Assert.IsTrue(order.Any());
        }

        [TestMethod]
        public void ImportLaserTag5()
        {
            var order = AllfleXML.LaserTag.Parser.Import(@"TestData\LaserTag\sample5.xml");
            Assert.IsNotNull(order);
            Assert.IsTrue(order.Any());
        }

        [TestMethod]
        public void ImportLaserTag6()
        {
            var order = AllfleXML.LaserTag.Parser.Import(@"TestData\LaserTag\sample6.xml");
            Assert.IsNotNull(order);
            Assert.IsTrue(order.Any());
        }

        [TestMethod]
        public void ImportLaserTag7()
        {
            var order = AllfleXML.LaserTag.Parser.Import(@"TestData\LaserTag\sample7.xml");
            Assert.IsNotNull(order);
            Assert.IsTrue(order.Any());
        }

        [TestMethod]
        public void ImportLaserTag8()
        {
            var order = AllfleXML.LaserTag.Parser.Import(@"TestData\LaserTag\sample8.xml");
            Assert.IsNotNull(order);
            Assert.IsTrue(order.Any());
        }

        [TestMethod]
        public void ImportLaserTag9()
        {
            var order = AllfleXML.LaserTag.Parser.Import(@"TestData\LaserTag\sample9.xml");
            Assert.IsNotNull(order);
            Assert.IsTrue(order.Any());
        }

        [TestMethod]
        public void ExportLaserTag()
        {
            var order = new AllfleXML.LaserTag.OrderHeader() { CustomerNumber = "testing" };

            var doc = AllfleXML.LaserTag.Parser.Export(order);
            Assert.IsNotNull(doc);

            var isValid = AllfleXML.LaserTag.Parser.Validate(doc);
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void FailedLaserTagValidation()
        {
            var isValid = AllfleXML.LaserTag.Parser.Validate(@"TestData\FlexOrder\sample0.xml");
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void PassedLaserTagValidation()
        {
            var isValid = AllfleXML.LaserTag.Parser.Validate(@"TestData\LaserTag\sample0.xml");
            Assert.IsTrue(isValid);
        }
    }
}
