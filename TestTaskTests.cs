using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Tests
{
    [TestClass]
    public class MathHelperTests
    {
        [TestMethod]
        public void ComputeTriangleAreaSmokeTest()
        {
            Assert.AreEqual(MathHelper.ComputeTriangleArea(3, 4, 5), 6);
        }

        [TestMethod]
        public void ComputeTriangleAreaSmokeTestWithCollection()
        {
            var list = new List<double>();
            list.Add(6);
            list.Add(8);
            list.Add(10);
            Assert.AreEqual(24, MathHelper.ComputeTriangleArea(list));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Given triangle is not right!")]
        public void ComputeTriangleAreaIncorrectTriangleTest()
        {
            MathHelper.ComputeTriangleArea(1, 2, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Length of a side can not be less than zero!")]
        public void ComputeTriangleAreaIncorrectSidesWithCollection()
        {
            var list = new List<double>();
            list.Add(6);
            list.Add(8);
            list.Add(-10);
            MathHelper.ComputeTriangleArea(list);
        }
    }
}
