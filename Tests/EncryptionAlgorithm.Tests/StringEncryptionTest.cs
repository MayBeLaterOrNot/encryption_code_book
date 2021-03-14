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
        public void EncryptText()
        {
            "������ǧ�������ַ��������ڽ���֮���õ�����ǰ���ַ�".Test(() =>
            {
                var originCharList = new char[2000];
                const string key = "�ֵ���";
                for (int i = 0; i < originCharList.Length; i++)
                {
                    originCharList[i] = '��';
                }

                var text = new string(originCharList);

                var byteList = StringEncryption.EncryptText(text, key);

                var decryptionText = StringEncryption.DecryptText(byteList, key);

                Assert.AreEqual(text, decryptionText);
            });

            "����һ�ٸ��ַ��������ڽ���֮���õ�����ǰ���ַ�".Test(() =>
            {
                var originCharList = new char[100];
                const string key = "�ֵ���";
                for (int i = 0; i < originCharList.Length; i++)
                {
                    originCharList[i] = 'a';
                }

                var text = new string(originCharList);

                var byteList = StringEncryption.EncryptText(text, key);

                var decryptionText = StringEncryption.DecryptText(byteList, key);

                Assert.AreEqual(text, decryptionText);
            });

            "������ǧ���ַ��������ڽ���֮���õ�����ǰ���ַ�".Test(() =>
            {
                var originCharList = new char[2000];
                const string key = "�ֵ���";
                for (int i = 0; i < originCharList.Length; i++)
                {
                    originCharList[i] = 'a';
                }

                var text = new string(originCharList);

                var byteList = StringEncryption.EncryptText(text, key);

                var decryptionText = StringEncryption.DecryptText(byteList, key);

                Assert.AreEqual(text,decryptionText);
            });
        }

        [ContractTestCase]
        public void Encryption()
        {
            "���ܼ��ַ��������ܺ��ܻ�ȡ����ǰ���ַ���".Test(() =>
            {
                var text = "�����ַ���";
                var key = "�ֵ���";

                var encryptionCharList = StringEncryption.Encrypt(text, key);
                var encryptionString = new string(encryptionCharList);
                var decryptionText = StringEncryption.Decrypt(encryptionString, key);

                Assert.AreEqual(text, decryptionText);
            });
        }

        [ContractTestCase]
        public void CharListToByteList()
        {
            "����һ������Char���飬����ת��ΪByte����".Test(() =>
            {
                var text = "�ֵ���";

                var charList = text.ToCharArray();
                // ��ת���ɹ����Ƕ���
                var byteList = StringEncryption.CharListToByteList(charList);
                var newByteList = StringEncryption.ByteListToCharList(byteList);

                Assert.AreEqual(text, new string(newByteList));
            });
        }

        [ContractTestCase]
        public void ByteListToCharList()
        {
            "����һ��Ӣ���ַ���������ת��ΪByte���飬������ת����ԭ���ַ���".Test(() =>
            {
                var text = "aasdfasdfasdf";

                var charList = text.ToCharArray();
                var byteList = StringEncryption.CharListToByteList(charList);
                var newByteList = StringEncryption.ByteListToCharList(byteList);

                Assert.AreEqual(text, new string(newByteList));
            });
        }
    }
}
