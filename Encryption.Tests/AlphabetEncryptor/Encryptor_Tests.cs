using System;
using Encryption.Helpers;
using Encryption.Interfaces;
using Encryption.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Encryption.Tests
{
    [TestClass]
    public class Encryptor_Tests
    {
        [TestMethod]
        public void Given_the_letter_a_is_passed_b_is_returned()
        {
            // Given I have the string 'a'
            // And I have the position of 1
            var value = 'a';
            var letterPosition = 1;

            // When I pass the string value into the alphabet encryptor.  
            IAlphabetEncryptor alphabetEncryptor = new AlphabetEncryptor(new AlphabetInitialiser());
            string result = alphabetEncryptor.EncryptMessage(value, letterPosition);

            // Then I expect the value returned is 'b'
            Assert.AreEqual("b", result);
        }

        [TestMethod]
        public void Given_the_letter_a_is_passed_c_is_returned()
        {
            // Given I have the string 'a'
            // And I have the position of 2
            var value = 'a';
            var letterPosition = 2;
            // When
            // I pass the string value into the alphabet encryptor.
            IAlphabetEncryptor alphabetEncryptor = new AlphabetEncryptor(new AlphabetInitialiser());
            string result = alphabetEncryptor.EncryptMessage(value, letterPosition);
            // Then I expect the value returned is 'c'
            Assert.AreEqual("c", result);
        }


        [TestMethod]
        public void Given_the_letter_a_is_passed_d_is_returned()
        {
            // Given I have the string 'a'
            // And I have the position of 3
            var value = 'a';
            var letterPosition = 3;
            // When
            // I pass the string value into the alphabet encryptor.
            IAlphabetEncryptor alphabetEncryptor = new AlphabetEncryptor(new AlphabetInitialiser());
            string result = alphabetEncryptor.EncryptMessage(value, letterPosition);
            // Then I expect the value returned is 'd'
            Assert.AreEqual("d", result);
        }


        [TestMethod]
        public void Given_the_letter_a_is_passed_k_is_returned()
        {
            // Given I have the string 'a'
            // And I have a position of 10
            var value = 'a';
            var letterPosition = 10;

            // When I pass the string value into the alphabet encryptor.
            IAlphabetEncryptor alphabetEncryptor = new AlphabetEncryptor(new AlphabetInitialiser());
            string actual = alphabetEncryptor.EncryptMessage(value, letterPosition);

            // Then I expect the value returned is 'k'
            Assert.AreEqual("k", actual);
        }

        [TestMethod]
        public void Given_the_letter_a_is_passed_z_is_returned()
        {
            // Given I have the string 'a'
            // And I have a position of 25
            var value = 'a';
            var letterPosition = 25;

            // When I pass the string value into the alphabet encryptor.
            IAlphabetEncryptor alphabetEncryptor = new AlphabetEncryptor(new AlphabetInitialiser());
            string actual = alphabetEncryptor.EncryptMessage(value, letterPosition);

            // Then I expect the value returned is 'z'
            Assert.AreEqual("z", actual);
        }

        [TestMethod]
        public void Given_the_letter_a_is_passed_a_is_returned()
        {
            // Given I have the string 'a'
            // And I have a position of 26
            var value = 'a';
            var letterPosition = 26;

            // When I pass the string value into the alphabet encryptor.
            IAlphabetEncryptor alphabetEncryptor = new AlphabetEncryptor(new AlphabetInitialiser());
            string actual = alphabetEncryptor.EncryptMessage(value, letterPosition);

            // Then I expect the value returned is 'a'
            Assert.AreEqual("a", actual);
        }


        [TestMethod]
        public void Given_the_letter_z_is_passed_a_is_returned()
        {
            // Given I have the string 'z'
            // And I have a position of 1
            var value = 'z';
            var letterPosition = 1;

            // When I pass the string value into the alphabet encryptor.
            IAlphabetEncryptor alphabetEncryptor = new AlphabetEncryptor(new AlphabetInitialiser());
            string actual = alphabetEncryptor.EncryptMessage(value, letterPosition);

            // Then I expect the value returned is 'a'
            Assert.AreEqual("a", actual);
        }

        [TestMethod]
        public void Given_the_letter_z_is_passed_b_is_returned()
        {
            // Given I have the string 'z'
            // And I have a position of 2
            var value = 'z';
            var letterPosition = 2;

            // When I pass the string value into the alphabet encryptor.
            IAlphabetEncryptor alphabetEncryptor = new AlphabetEncryptor(new AlphabetInitialiser());
            string actual = alphabetEncryptor.EncryptMessage(value, letterPosition);

            // Then I expect the value returned is 'b'
            Assert.AreEqual("b", actual);
        }


        [TestMethod]
        public void Given_the_letter_z_is_passed_c_is_returned()
        {
            // Given I have the string 'z'
            // And I have a position of 2
            var value = 'z';
            var letterPosition = 3;

            // When I pass the string value into the alphabet encryptor.
            IAlphabetEncryptor alphabetEncryptor = new AlphabetEncryptor(new AlphabetInitialiser());
            string actual = alphabetEncryptor.EncryptMessage(value, letterPosition);

            // Then I expect the value returned is 'c'
            Assert.AreEqual("c", actual);
        }

        [TestMethod]
        public void Given_the_letter_a_is_passed_a_is_returned_again()
        {
            // Given I have the string 'a'
            // And I have a position of 52
            var value = 'a';
            var letterPosition = 52;

            // When I pass the string value into the alphabet encryptor.
            IAlphabetEncryptor alphabetEncryptor = new AlphabetEncryptor(new AlphabetInitialiser());
            string actual = alphabetEncryptor.EncryptMessage(value, letterPosition);

            // Then I expect the value returned is 'a'
            Assert.AreEqual("a", actual);
        }

        [TestMethod]
        public void Given_the_letter_a_is_passed_b_is_returned_again()
        {
            // Given I have the string 'a'
            // And I have a position of 53
            var value = 'a';
            var letterPosition = 53;

            // When I pass the string value into the alphabet encryptor.
            IAlphabetEncryptor alphabetEncryptor = new AlphabetEncryptor(new AlphabetInitialiser());
            string actual = alphabetEncryptor.EncryptMessage(value, letterPosition);

            // Then I expect the value returned is 'a'
            Assert.AreEqual("b", actual);
        }

        [TestMethod]
        public void Given_the_letter_a_is_passed_c_is_returned_again()
        {
            // Given I have the string 'a'
            // And I have a position of 54
            var value = 'a';
            var letterPosition = 54;

            // When I pass the string value into the alphabet encryptor.
            IAlphabetEncryptor alphabetEncryptor = new AlphabetEncryptor(new AlphabetInitialiser());
            string actual = alphabetEncryptor.EncryptMessage(value, letterPosition);

            // Then I expect the value returned is 'a'
            Assert.AreEqual("c", actual);
        }


    }
}
