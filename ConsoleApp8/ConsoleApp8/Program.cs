//Добавить проверку на корректность пользовательского ввода, чтобы избежать исключений при некорректном вводе.
//Добавить возможность для пользователя повторно вводить число N в случае некорректного ввода.
//Добавить комментарии к коду, чтобы сделать его более понятным и легким для чтения.
using System.Text;

namespace Library
{
    public class ZadanieOne
    {
        public void One()
        {
            Console.Write("Введите число N: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n)) // проверка на корректный ввод числа
            {
                Console.Write("Некорректный ввод. Введите число N: ");
            }
            string result = string.Join(", ", Enumerable.Range(1, n));
            Console.WriteLine(result);
        }
    }
    public class ZadanieTwo
    {
        public static void Two()
        {
            Console.Write("Введите нечетное число N: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n % 2 == 0) // проверка на корректный ввод нечетного числа
            {
                Console.Write("Некорректный ввод. Введите нечетное число N: ");
            }
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row == n / 2 + 1 && col == n / 2 + 1) Console.Write(" ");
                    else Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // вызов методов из классов ZadanieOne и ZadanieTwo
            ZadanieOne zadanieOne = new ZadanieOne();
            zadanieOne.One();

            ZadanieTwo.Two();

            Console.ReadKey();
        }
    }
}
