using System.Numerics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void шифрRSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int p = 23;
            int g = 5;
            int x = 18;
            int k = 7;
            int m = 16;
            int y = (int)BigInteger.ModPow(g, x, p);
            int r = (int)BigInteger.ModPow(g, k, p);
            int s = (int)ModInverse(k, p - 1) * (m - x * r) % (p - 1);
            bool isValid = VerifySignature(p, g, y, m, r, s);
            MessageBox.Show($"Открытый ключ  y = {y} \n Подпись: (r, s) = ({r},{s}) \n Проверка подписи: {isValid}");
        }
        static int ModInverse(int a, int m)
        {
            int m0 = m, t, q;
            int x0 = 0, x1 = 1;

            if (m == 1)
                return 0;

            while (a > 1)
            {
                q = a / m;
                t = m;
                m = a % m;
                a = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0)
                x1 += m0;

            return x1;
        }

        static bool VerifySignature(int p, int g, int y, int m, int r, int s)
        {
            int w = ModInverse(s, p - 1);
            int u1 = (int)(m * w % (p - 1));
            int u2 = (int)(r * w % (p - 1));
            int v = (int)(BigInteger.ModPow(g, u1, p) * BigInteger.ModPow(y, u2, p) % p % (p - 1));
            return v == r;
        }

        private void эЦКElToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BigInteger n = 55;
            BigInteger e_ = 3;
            Tuple<BigInteger, BigInteger>[] messages = new Tuple<BigInteger, BigInteger>[] {
            Tuple.Create(new BigInteger(15), new BigInteger(71)),
            Tuple.Create(new BigInteger(11), new BigInteger(46)),
            Tuple.Create(new BigInteger(16), new BigInteger(74))
             };
            foreach (Tuple<BigInteger, BigInteger> message in messages)
            {
                BigInteger M = message.Item1;//хеш значения 

                BigInteger s = message.Item2;

                BigInteger M_ = BigInteger.ModPow(s, e_, n);

                if (M == M_)
                {
                    MessageBox.Show($"Подпись верна для сообщения M = {M}");
                }
                else
                {
                    MessageBox.Show($"Подпись не верна для сообщения M = {M}");
                }
            }
        }
    }
}