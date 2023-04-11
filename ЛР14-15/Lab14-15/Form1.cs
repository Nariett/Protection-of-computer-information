using System;
using System.Drawing.Imaging;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Lab14_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string decryptedMessag;
        private void button1_Click(object sender, EventArgs e)
        {

            int p = 11;
            int q = 2;
            int x = 8; 
            int y = (int)BigInteger.ModPow(q, x, p); // вычисляем открытый ключ

            string message = this.textBox1.Text;
            decryptedMessag = message;
            int[] asciiValues = new int[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                asciiValues[i] = Convert.ToInt32(message[i]);
            }

            int k = 9; // выбираем случайное число

            int[] aValues = new int[asciiValues.Length];
            int[] bValues = new int[asciiValues.Length];

            // Шифруем каждый символ отдельно
            for (int i = 0; i < asciiValues.Length; i++)
            {
                int M = asciiValues[i];

                int a = (int)BigInteger.ModPow(q, k, p); // вычисляем a
                int b = (int)BigInteger.ModPow(y, k, p) * M % p; // вычисляем b

                aValues[i] = a;
                bValues[i] = b;
            }

            int[] decryptedAsciiValues = new int[asciiValues.Length];

            for (int i = 0; i < asciiValues.Length; i++)
            {
                int a = aValues[i];
                int b = bValues[i];

                int decryptedM = (int)BigInteger.ModPow(a, p - 1 - x, p) * b % p;
                decryptedAsciiValues[i] = decryptedM;
            }

            string decryptedMessage = "";

            for (int i = 0; i < decryptedAsciiValues.Length; i++)
            {
                decryptedMessage += (char)decryptedAsciiValues[i];
            }
            this.textBox2.Text = decryptedMessag;
        }
    }
}
