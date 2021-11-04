using System;

namespace LR2J
{
    class Program
    {
        static void Main(string[] args)
        {
            Sklad mysklad = Sklad.Initialisation();
            Console.WriteLine("Система готова к работе!");
            Console.WriteLine("Идентификация пользователя:");
            Console.Write("ФИО > ");
            String fiop = Console.ReadLine();
            Polzovatel klient = new Polzovatel(fiop);
            int operation = 0;
            do
            {
                Console.Write("Уважаемый " + klient.fio + ", выберите дейстиве: \n1 - Вывод ассортимента\n" + "2 - Запрос запасов\n3 - Возврат запасов\n" + "0 - Exit\n Ваш выбор > ");
                operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1: mysklad.Assortiment(); break;
                    case 2:
                        Console.Write("Код продукта? > ");
                        String kod = Console.ReadLine();
                        mysklad.PokupkaZapasi(kod, klient);
                        break;
                    case 3:
                        mysklad.VozvratBraka(klient);
                        break;
                    default: break;
                }
            } while (operation != 0);

            Console.WriteLine("Склад работа завершена!");
        }
    }
}
