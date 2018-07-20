using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encryption.Interfaces;
using Encryption.Services;
using Encryption.Helpers;

namespace Encryption.Tests
{
    [TestClass]
    public class Case_Encryptor_Tests
    {
        [TestMethod]
        public void Value_is_z_And_it_returns_Z()
        {
            // Given I have a character of 'z' 
            var value = 'z';

            // When I pass the value to the alphabet encryptor
            ICaseEncryptor caseEncryptor = new CaseEncryptor();
            var result = caseEncryptor.Transform(value);

            // Then I expect the value to be 'Z'
            Assert.AreEqual("Z", result);
        }

        [TestMethod]
        public void Value_is_a_And_it_returns_A()
        {
            // Given I have a character of 'a' 
            var value = 'a';
             
            // When I pass the value to the alphabet encryptor
            ICaseEncryptor caseEncryptor = new CaseEncryptor();
            var result = caseEncryptor.Transform(value);

            // Then I expect the value to be 'B'
            Assert.AreEqual("A", result);
        }

        [TestMethod]
        public void Value_is_b_And_it_returns_B()
        {
            // Given I have a character of 'b'
            var value = 'b';

            // When I pass the value to the alphabet encryptor
            ICaseEncryptor caseEncryptor = new CaseEncryptor();
            var result = caseEncryptor.Transform(value);

            // Then I expect the value to be 'B'
            Assert.AreEqual("B", result);
        }


        [TestMethod]
        public void Value_is_c_And_it_returns_C()
        {
            // Given I have a character of 'c' 
            var value = 'c';

            // When I pass the value to the alphabet encryptor
            ICaseEncryptor caseEncryptor = new CaseEncryptor();
            var result = caseEncryptor.Transform(value);

            // Then I expect the value to be 'B'
            Assert.AreEqual("C", result);
        }

    }
}
