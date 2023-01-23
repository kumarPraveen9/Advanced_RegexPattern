using day16;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace RegexTestCase
{
    [TestClass]
    public class UnitTest1
    {
        /* try
            {
                Result = validation.Test_First(firstName);
                Assert.AreEqual("First Name is valid", Result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual("\nMinimum length three characters \nFirst letter should be " +
                    "capital\n", ex.Message);
            }*/
        [TestMethod]
        public void UseCase1()
        {
            try
            {
                string name = "Shankerma";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validname(name);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid first name", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase2()
        {
            try
            {
                string lastname = "ShivajiMa";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validlname(lastname);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid last name", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase3()
        {
            try
            {
                string[] emails = new string[3] { "abc.xyz@bl.co.in", "a123@bl.co.in", "fhjjm33@bl.co" };

                for (int i = 0; i < 3; i++)
                {

                    bool expected = true;
                    demo program = new demo();
                    bool actual = program.validmail(emails[i]);
                    Assert.AreEqual(expected, actual);
                }
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid mail", ex.Message);
            }

        }

        [TestMethod]
        public void UseCase4()
        {
            try
            {
                string mb = "91 7330827008";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validmobile(mb);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid mobile number", ex.Message);
            }
        }
        [TestMethod]
        public void UseCase5()
        {
            try
            {
                string password = "Ooliisaap";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validpwd1(password);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid password", ex.Message);
            }

        }

        [TestMethod]
        public void UseCase6()
        {
            try
            {
                string password = "Praveenn";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validpwd2(password);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid password", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase7()
        {
            try
            {
                string password = "Praveen9";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validpwd3(password);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid password", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase8()
        {
            try
            {
                string password = "Pravee$9";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validpwd(password);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid password", ex.Message);
            }
        }

        [TestMethod]
        public void UseCase9()
        {
            try
            {
                string email1 = "abc.xyz@gmail.com";
                bool expected = true;
                demo program = new demo();
                bool actual = program.validmail(email1);
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("invalid password", ex.Message);
            }
        }
    }
}
