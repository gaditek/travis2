using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTest
{
    [TestFixture]
    public class ObjTest
    {
        int i = 0;

        [SetUp]
        protected void SetUp()
        {
            i = 4;
        }

        [Test]
        public void TwoPlusTwoFour()
        {
            Assert.AreEqual(2 + 2, i);
        }
    }
}
