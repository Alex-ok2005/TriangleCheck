using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangles;

namespace UnitTestTriangles
{
    [TestClass]
    public class TrianglesTest
    {
        [TestMethod]
        public void TestNoneResult()
        {
            var triangleCheckInstance = new TriangleCheck();
            TriangleCheck.TriangleType result = triangleCheckInstance.Check(1, 1, 3);
            Assert.AreEqual(TriangleCheck.TriangleType.None, result);
        }
        [TestMethod]
        public void TestAcuteResult()
        {
            var triangleCheckInstance = new TriangleCheck();
            TriangleCheck.TriangleType result = triangleCheckInstance.Check(1, 1, 1);
            Assert.AreEqual(TriangleCheck.TriangleType.Acute, result);
        }
        [TestMethod]
        public void TestRightResult()
        {
            var triangleCheckInstance = new TriangleCheck();
            TriangleCheck.TriangleType result = triangleCheckInstance.Check(3, 4, 5);
            Assert.AreEqual(TriangleCheck.TriangleType.Right, result);
        }
        [TestMethod]
        public void TestObtuseResult()
        {
            var triangleCheckInstance = new TriangleCheck();
            TriangleCheck.TriangleType result = triangleCheckInstance.Check(2, 2, 3);
            Assert.AreEqual(TriangleCheck.TriangleType.Obtuse, result);
        }
    }
}
