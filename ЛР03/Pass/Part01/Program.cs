using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст который хотиите зашифровать");
            string text = Console.ReadLine();
            char[,] shifr = { {'а','б','в','г','д','е','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я'},{
                               'з','у','ш','в','ь','я','ж','щ','к','г','л','ф','м','д','п','ъ','ы','и','ю','о','с','н','й','т','ч','б','а','э','х','ц','е','р'} };
            string text2 = "";
            for(int i = 0;i<text.Length;i++)
            {
                for(int j = 0;j<32;j++)
                {
                    if (text[i] == shifr[0,j])
                    {
                        text2 += shifr[1, j];
                    }
                    if (text[i] == ' ')
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine($"Шифр по смежной таблице {text2}");
            Console.ReadLine();
        }
    }
}
