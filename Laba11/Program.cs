using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1");
            ACipher aCipher = new ACipher();
            int k = 1;
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            string ciphertext = aCipher.Encoding(text, k);
            string decryptedtext = aCipher.Decoding(ciphertext, k);
            Console.WriteLine($"Зашифрованный текст в классе ACipher: {ciphertext}");

            BCipher bCipher = new BCipher();
            ciphertext = bCipher.Encoding(text, k);
            decryptedtext = bCipher.Decoding(ciphertext, k);
            Console.WriteLine($"Этот же текст, зашифрованный в классе BCipher: {ciphertext}");
            Console.WriteLine($"Расшифрованный текст: {decryptedtext}");

            Console.WriteLine("Домашнее задание 10.1");
            Circle circle = new Circle(5);
            Console.WriteLine("Введите цвет фигуры(на англ):");
            string color = Console.ReadLine();
            circle.ChangeColor(color);
            circle.Status();
            Console.WriteLine("Хотите переместить фигуру?");
            string answer = Console.ReadLine().ToLower();
            if (answer.Equals("yes"))
            {
                Console.WriteLine("Введите координаты и перемещение:");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int num = int.Parse(Console.ReadLine());
                circle.Movement(x, y, num);
            }
            else
            {
                Console.WriteLine($"Площадь: {circle.Square()}");
            }
            circle.Print();

            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine("Введите цвет фигуры:");
            color = Console.ReadLine();
            rectangle.ChangeColor(color);
            Console.WriteLine($"Площадь прямоугольника: {rectangle.Square()}");
            rectangle.Print();
            Console.ReadKey();
        }
    }
}
