using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsTrial;

namespace JenkinsTrialUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int A = 2;
            int B = 3;
            int expected = 5;

            MathematicsOperation maths = new MathematicsOperation();
            int actual = maths.Add(A, B);

            Assert.AreEqual(expected, actual);
        }
    }
}
