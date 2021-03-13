using System;
using Lindexi.Src.EncryptionAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest.Extensions.Contracts;

namespace EncryptionAlgorithm.Tests
{
    [TestClass]
    public class StringEncryptionTest
    {
        [ContractTestCase]
        public void Encryption()
        {
            "���ܼ��ַ��������ܺ��ܻ�ȡ����ǰ���ַ���".Test(() =>
            {
                var text = "�����ַ���";
                var key = "�ֵ���";

                var encryptionCharList = StringEncryption.Encrypt(text,key);
                var encryptionString = new string(encryptionCharList);
                var decryptionText = StringEncryption.Decrypt(encryptionString,key);

                Assert.AreEqual(text, decryptionText);
            });
        }
    }
}
