using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using JenkinsTrial;

namespace JenkinsTrialNUnitTest
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
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
