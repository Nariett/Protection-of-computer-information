using System;
using System.Security.Cryptography;
using System.Text;

namespace Lab07
{
    class Program
    {
        static void Main()
        {

            RSA gen = new RSA(); 
            UnicodeEncoding ByteConverter = new UnicodeEncoding();

            //Создавайте массивы байтов для хранения исходных, зашифрованных и расшифрованных данных..
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            byte[] dataToEncrypt = ByteConverter.GetBytes(text);
            byte[] encryptedData;
            byte[] decryptedData;

            //Создаётся новый экземпляр RSACryptoServiceProvider для создания
            //данных открытого и закрытого ключей.
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                //Передайте данные в ENCRYPT, информацию об открытом ключе. 
                //(с использованием RSACryptoServiceProvider.ExportParameters(false),
                //а также логический флаг, указывающий отсутствие заполнения OAEP
                encryptedData = gen.RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);

                //Передайте данные в DECRYPT, информацию о секретном ключе 
                //(с использованием RSACryptoServiceProvider.ExportParameters(true),
                //а также логический флаг, указывающий отсутствие заполнения OAEP.
                decryptedData = gen.RSADecrypt(encryptedData, RSA.ExportParameters(true), false);
                byte[] Data = encryptedData;
                Console.WriteLine("Зашифрованный текст:");
                for (int i = 0; i < Data.GetLength(0); i++)
                {
                    Console.Write(Data[i] + " ");
                }
                Console.Write("\n");
                //Console.WriteLine("Зашифрованный текст: {0}", ByteConverter.GetString(encryptedData));
                Console.WriteLine("Расшифрованный текст: {0}", ByteConverter.GetString(decryptedData));

            }
            Console.ReadKey();
        }
    }
}