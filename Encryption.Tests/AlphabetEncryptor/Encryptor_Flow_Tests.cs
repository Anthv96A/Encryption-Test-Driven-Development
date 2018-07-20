using System;
using Encryption.Interfaces;
using Encryption.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Encryption.Tests
{
    [TestClass]
    public class Encryptor_Flow_Tests
    {
        [TestMethod]
        public void Given_word_is_a_the_encryptor_is_called_once()
        {
            // Given I have the string 'a'
            var word = "a";
            // When I pass the string value into the alphabet encryptor.
            Mock<IAlphabetEncryptor> mockEncryptor = new Mock<IAlphabetEncryptor>();
            
            IEncryptorFlow encryptorFlow = new EncryptorFlow(mockEncryptor.Object);
            encryptorFlow.EncryptValue(word);

            // Then I expect the method is called once only
            mockEncryptor.Verify(m => 
                    m.EncryptMessage(It.IsAny<Char>(), It.IsAny<int>()),
                    Times.Once);
        }

        [TestMethod]
        public void Given_word_is_ab_the_encryptor_is_called_twice()
        {
            // Given I have the string 'ab'
            var word = "ab";
            // When I pass the string value into the alphabet encryptor.
            Mock<IAlphabetEncryptor> mockEncryptor = new Mock<IAlphabetEncryptor>();

            IEncryptorFlow encryptorFlow = new EncryptorFlow(mockEncryptor.Object);
            encryptorFlow.EncryptValue(word);

            // Then I expect the method is called twice
            mockEncryptor.Verify(m => 
                    m.EncryptMessage(It.IsAny<Char>(), It.IsAny<int>()), 
                    Times.Exactly(2));
        }

        [TestMethod]
        public void Given_word_is_abc_the_encryptor_is_called_three_times()
        {
            // Given I have the string 'abc'
            var word = "abc";

            // When I pass the string value into the alphabet encryptor
            Mock<IAlphabetEncryptor> mockEncryptor = new Mock<IAlphabetEncryptor>();

            IEncryptorFlow encryptorFlow = new EncryptorFlow(mockEncryptor.Object);
            encryptorFlow.EncryptValue(word);

            // Then I expected the method is called three times.
            mockEncryptor.Verify(me => 
                        me.EncryptMessage(It.IsAny<char>(), It.IsAny<int>()), 
                        Times.Exactly(3));
           
        }

        [TestMethod]
        public void Given_word_is_abcdef_the_encryptor_is_called_six_times()
        {
            // Given I have the string 'abcdef'
            var word = "abcdef";

            // When I pass the string value into the alphabet encryptor
            Mock<IAlphabetEncryptor> mockEncryptor = new Mock<IAlphabetEncryptor>();

            IEncryptorFlow encryptorFlow = new EncryptorFlow(mockEncryptor.Object);
            encryptorFlow.EncryptValue(word);

            // Then I expected the method is called three times.
            mockEncryptor.Verify(me =>
                        me.EncryptMessage(It.IsAny<char>(), It.IsAny<int>()),
                        Times.Exactly(6));

        }

        [TestMethod]
        public void Given_word_is_abcdefghij_the_encryptor_is_called_ten_times()
        {
            // Given I have the string 'abc'
            var word = "abcdefghij";

            // When I pass the string value into the alphabet encryptor
            Mock<IAlphabetEncryptor> mockEncryptor = new Mock<IAlphabetEncryptor>();

            IEncryptorFlow encryptorFlow = new EncryptorFlow(mockEncryptor.Object);
            encryptorFlow.EncryptValue(word);

            // Then I expected the method is called three times.
            mockEncryptor.Verify(me =>
                        me.EncryptMessage(It.IsAny<char>(), It.IsAny<int>()),
                        Times.Exactly(10));
        }
    }
}
