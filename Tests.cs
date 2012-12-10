using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_M()
        {
            var sut = new Blah();
            Assert.AreEqual(42, sut.M());
        }
    }

    public class Blah
    {
        public int M()
        {
            return 5;
        }
    }
}
