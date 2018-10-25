using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldOfTanks;
//Разработать программу, моделирующую танковый бой.
//В танковом бою участвуют 5 танков «Т-34» и 5 танков «Pantera». Каждый танк («Т-34» и «Pantera»)
//описываются параметрами: «Боекомплект», «Уровень брони», «Уровень маневренности». 
//Значение данных параметров задаются случайными числами от 0 до 100. Каждый танк участвует в парной битве,
//т.е.первый танк «Т-34» сражается с первым танком «Pantera» и т.д.Победа присуждается тому танку, 
//который превышает противника по двум и более параметрам из трех (пример: см.программу). 
//Основное требование: сражение(проверку на победу в бою) реализовать путем перегрузки оператора «*» 
//(произведение). 
//1.	В решение добавить новый проект с именем «Day7(Tanks)», в котором будут промоделированы 
//танковые сражения.В данный проект добавить ссылку на библиотеку классов «MyClassLib».
//2.	В библиотеке классов «MyClassLib» создать папку «WordOfTanks», а в ней разработать класс 
//с именем «Tank».
//В классе должно быть реализовано
//●	Поля
//закрытые поля, предназначенные для представления
//1.	Названия танка.
//2.	Уровня боекомплекта танка.
//3.	Уровня брони. 
//4.	Уровня маневренности.
//●	Конструктор
//Конструктор с параметрами, обеспечивающий инициализацию всех полей класса Tank. 
//При этом Боекомплект, Уровень брони, Уровень маневренности инициализируются
//случайными числами от 0 до 100 %. Название танка передаются в конструктор из функции Main(). 
//●	Перегрузка оператора «*»(произведение)
//При перегрузке оператора «*» (произведение) должна быть реализована проверка на победу
//в бою одного танка по отношению к другому.Критерий победы — победивший танк должен 
//превышать проигравший танк не менее чем по двум из трех параметров 
//(Боекомплект, Уровень брони, Уровень маневренности). 
//●	Методы:
//Получение текущих значений параметров танка: Бое­комплект, Уровень брони, 
//Уровень маневренности в виде строки.

//Важно! При разработке программы использовать обработку исключительных ситуаций.
//Варианты возможных исключительных ситуаций рассмотреть самостоятельно!


namespace OverloadingOperatorsHW
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Tank> division1 = new List<Tank>();
            List<Tank> division2 = new List<Tank>();


            Console.WriteLine("Инициализация танков...");
            Tank tank1 = new Tank("tank1Q");
            System.Threading.Thread.Sleep(50);
            Tank tank2 = new Tank("tank2Q");
            System.Threading.Thread.Sleep(50);
            Tank tank3 = new Tank("tank3Q");
            System.Threading.Thread.Sleep(50);
            Tank tank4 = new Tank("tank4Q");
            System.Threading.Thread.Sleep(50);
            Tank tank5 = new Tank("tank5Q");
            System.Threading.Thread.Sleep(50);
            Tank tank6 = new Tank("tank1R");
            System.Threading.Thread.Sleep(50);
            Tank tank7 = new Tank("tank2R");
            System.Threading.Thread.Sleep(50);
            Tank tank8 = new Tank("tank3R");
            System.Threading.Thread.Sleep(50);
            Tank tank9 = new Tank("tank4R");
            System.Threading.Thread.Sleep(50);
            Tank tank10 = new Tank("tank5R");
            System.Threading.Thread.Sleep(50);

            division1.Add(tank1);
            division1.Add(tank2);
            division1.Add(tank3);
            division1.Add(tank4);
            division1.Add(tank5);
            division2.Add(tank6);
            division2.Add(tank7);
            division2.Add(tank8);
            division2.Add(tank9);
            division2.Add(tank10);

            List<Tank> winners = new List<Tank>();

            for (int i = 0; i < 5; i++)
            {
                winners.Add(division1[i]*division2[i]);
            }
            Console.Clear();
            foreach (var tank in winners)
            {
                Console.WriteLine(tank.Name);

            }

            Console.Read();
            
        }
    }
}
