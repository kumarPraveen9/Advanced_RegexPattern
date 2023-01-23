using day16;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace RegexTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UseCase1()
        {
            string name = "Shankerma";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validname(name);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase2()
        {
            string lastname = "ShivajiMa";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validlname(lastname);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase3()
        {
            string email = "abc.xyz@bl.co.in";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validmail(email);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase4()
        {
            string mb = "91 7330827008";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validmobile(mb);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UseCase5()
        {
            string password = "Ooliisaap";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validpwd1(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase6()
        {
            string password = "Praveenn";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validpwd2(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase7()
        {
            string password = "Praveen9";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validpwd3(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase8()
        {
            string password = "Pravee$9";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validpwd(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase9()
        {
            string email1 = "abc.xyz@gmail.com";
            bool expected = true;
            demo program = new demo();
            bool actual = program.validmail(email1);
            Assert.AreEqual(expected, actual);
        }
    }
}
