using EncryptionSample;

namespace EncryptionSampleTestProject
{
    [TestClass]
    public class TeimorianCryptoTests
    {
        [TestMethod]
        public void TestEncryption()
        {
            TeimorianCrypto tc = new TeimorianCrypto("abc");
            string expected = "cba";
            string actual=tc.Encrypt();

            Assert.AreEqual(expected, actual);  
        }

        [TestMethod]
        public void TestDecryption()
        {
            TeimorianCrypto tc = new TeimorianCrypto("cba");
            string expected = "abc";
            string actual = tc.Encrypt();

            Assert.AreEqual(expected, actual);
        }
    }
}