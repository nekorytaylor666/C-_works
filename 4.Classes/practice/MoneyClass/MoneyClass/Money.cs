using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyClass
{
    //    Поля:
    //- Номинал купюры
    //- Количество купюр
    //Конструктор:
    //- Позволяющий создать экземпляр класса с заданными значениям полей
    //Свойства:
    //	- Позволяющее получить-установить значение полей(доступное для чтения и записи)
    //	- Позволяющее расчитать сумму денег(доступное только для чтения)
    class Money
    {
        private int _denomination;
        private int _countOfBanknotes;

        Money(int demonation, int count)
        {
            _denomination = demonation;
            _countOfBanknotes = count;
        }
    //Методы:
    //- Вывести номинал и количество купюр
    //- Определить, хватит ли денежных средств на покупку товара на сумму N тенге
    //	- Определить, сколько штук товара стоимости n тенге можно купить на имеющиеся денежные средства

        public void Print()
        {
            Console.WriteLine($"Тут {_countOfBanknotes} купюр номиналом {_denomination}.");
        }

        public bool IsEnough(int cost)
        {
            if (cost <= _denomination * _countOfBanknotes)
            {
                return true;
            }
            else return false;
        }

        public int HowManyWorth(int cost)
        {
            if (!this.IsEnough(cost))
            {
                return 0;
            }
            else
            {
               return this.SumMoney()/ cost;
            }
        }

        public int SumMoney()
        {
            return _denomination * _countOfBanknotes;
        }

        //private int _denomination;
        //private int _countOfBanknotes;

        public void SetDenomination(int denomination)
        {
            _denomination = denomination;
        }

        public int GetDenomination()
        {
            return _denomination;
        }

        public void SetCountBanknotes(int count)
        {
            _countOfBanknotes = count;
        }

        public int GetCountBanknotes()
        {
            return _countOfBanknotes;
        }
    }
}
