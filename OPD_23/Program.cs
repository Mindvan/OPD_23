using System;

namespace OPD_23
{
    internal class Program
    {
        static void MakeSort()
        {
            Matrix matrix = new Matrix();

            while (true)
            {            
                Console.Clear();
                Console.WriteLine("Задание №1\n");
                Console.WriteLine("1 – Выбрать алгоритм сортировки");
                Console.WriteLine("2 – Выбрать тип сортировки");
                Console.WriteLine("3 – Отсортировать матрицу");
                Console.WriteLine("0 - Вернуться назад\n");
                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case '1':
                        ChoseStrategy(ref matrix);
                        break;
                    case '2':
                        ChoseType(ref matrix);
                        break;
                    case '3':
                        Console.Clear();
                        Console.Write("ДО:\t");
                        matrix.Show();
                        matrix.SortMatrix();
                        Console.Write("ПОСЛЕ:\t");
                        matrix.Show();
                        Console.WriteLine("\nНажмите на любую клавишу для продолжения.\n");
                        Console.ReadKey();
                        break;
                    case '0':
                        return;
                    default:
                        break;
                }
            }

        }
        static void ChoseStrategy(ref Matrix mat)
        {
            Console.Clear();
            Console.WriteLine("Как алгоритм выбрать?\n");
            Console.WriteLine("1 – Пузырьковая сортировка");
            Console.WriteLine("0 - Вернуться назад\n");
            switch (char.ToLower(Console.ReadKey(true).KeyChar))
            {
                case '1':
                    mat.setAlgorythm(new BubbleSort());
                    break;
                case '0':
                    return;
                default:
                    break;
            }
        }
        static void ChoseType(ref Matrix mat)
        {
            Console.Clear();
            Console.WriteLine("Как упорядочить строки матрицы?\n");
            Console.WriteLine("1 – В порядке возрастания сумм элементов строк матрицы");
            Console.WriteLine("2 – В порядке убывания сумм элементов строк матрицы");
            Console.WriteLine("3 - По возрастанию максимального элемента в строке матрицы");
            Console.WriteLine("4 – По убыванию максимального элемента в строке матрицы");
            Console.WriteLine("5 - В порядке возрастания минимального элемента в строке матрицы");
            Console.WriteLine("6 – В порядке убывания минимального элемента в строке матрицы\n");
            Console.WriteLine("0 - Вернуться назад");
            switch (char.ToLower(Console.ReadKey(true).KeyChar))
            {
                case '1':
                    mat.setType(new SumType(true));
                    break;
                case '2':
                    mat.setType(new SumType(false));
                    break;
                case '3':
                    mat.setType(new MaxType(true));
                    break;
                case '4':
                    mat.setType(new MaxType(false));
                    break;
                case '5':
                    mat.setType(new MinType(true));
                    break;
                case '6':
                    mat.setType(new MinType(false));
                    break;
                case '0':
                    return;
                default:
                    break;
            }
        }
        static void Observer()
        {
            int time = 3000;
            string message = "MESSAGE_TEST";
            Countdown cd = new Countdown();
            cd.Attach(new SubscriberA());
            cd.Attach(new SubscriberB());
            cd.Attach(new SubscriberC());
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Задание №2\n");
                Console.WriteLine("1 – Задать сообщение");
                Console.WriteLine("2 – Задать задержку");
                Console.WriteLine("3 – Отправить сообщение");
                Console.WriteLine("0 - Вернуться назад\n");
                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Введите сообщение: ");
                        message = Console.ReadLine();
                        break;
                    case '2':
                        Console.Clear();
                        Console.Write("Задайте время задержки (в миллисекундах):");
                        Int32.TryParse(Console.ReadLine(), out time);
                        break;
                    case '3':
                        Console.Clear();
                        cd.SendMessages(message, time);
                        Console.WriteLine("\nНажмите на любую клавишу для продолжения.");
                        Console.ReadKey();
                        break;
                    case '0':
                        return;
                    default:
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Практическое задание №2");
                Console.WriteLine("1 - Задание №1: Сортировка");
                Console.WriteLine("2 - Задание №2: Передача сообщения");
                Console.WriteLine("0 - Выйти из программы");
                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case '1':
                            MakeSort();
                        break;
                    case '2':
                            Observer();
                        break;
                    case '0':
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
