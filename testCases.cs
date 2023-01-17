using Day19RejexAssignment;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.CodeAnalysis;

namespace RegexTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UseCase1()
        {            
            string name = "Krishna";
            bool expected = true; 
            Program program=new Program();
            bool actual = program.val(name);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase2()
        {
            string lastname = "Radha";
            bool expected = true;
            Program program=new Program();
            bool actual = program.val(lastname);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase3()
        {
            string email = "abc.xyz@bl.co.in";
            bool expected = true;
            Program program=new Program();
            bool actual = program.val(email);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase4()
        {
            string mb = "91 7985369532";
            bool expected = true;
            Program program=new Program();
            bool actual = program.val(mb);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UseCase5()
        {
            string password = "krishnap";
            bool expected = true;
            Program program=new Program();
            bool actual = program.val(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase6()
        {
            string password = "Krishnap";
            bool expected = true;
            Program program=new Program();
            bool actual = program.val(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase7()
        {
            string password = "Dhanas8w";
            bool expected = true;
            Program program=new Program();
            bool actual = program.val(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase8()
        {
            string password = "Kifnj@78a";
            bool expected = true;
            Program program=new Program();
            bool actual = program.val(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase9()
        {
            string email1 = "abc.xyz@gmail.com";
            bool expected = true;
            Program program=new Program();
            bool actual = program.val(email1);
            Assert.AreEqual(expected, actual);
        }
    }
}
