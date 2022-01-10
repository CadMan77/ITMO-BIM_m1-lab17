using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1.Создать класс для моделирования счета в банке.
// Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
// Класс должен быть объявлен как обобщенный.
// Универсальный параметр T должен определять тип номера счета.
// Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
// Создать  несколько экземпляров класса, параметризированного различными типам.
// Заполнить его поля и вывести информацию об экземпляре класса на печать.

namespace ITMO_BIM_m1_lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Acount<int> Ac1 = new Acount<int>();
            Ac1.Number = 2; 
            Ac1.Balance = 300;
            Ac1.Fullname = "Пупкин Василий Алибабаевич";

            Acount<string> Ac2 = new Acount<string>();
            Ac2.Number = "0001";
            Ac2.Balance = 1000000000;
            Ac2.Fullname = "Драмп Тональд Дональдович";

            Console.WriteLine("Лайфхак: Превращаем мужа в мультимиллионера за 1 час (без СМС и регистрации)");
            Console.WriteLine();
            Console.WriteLine("Исходное состояние счета клиента:");
            Console.WriteLine($"\tНомер счета: {Ac2.GetNumber()}\n\tФИО владельца счета: {Ac2.GetFullname()}\n\tБаланс: {Ac2.GetBalance()}");
            Console.WriteLine();

            Ac2.SetBalance(999000000);

            Console.WriteLine("После похожа жены клиента \"за хлебушком\":");
            Console.WriteLine($"\tНомер счета: {Ac2.GetNumber()}\n\tФИО владельца счета: {Ac2.GetFullname()}\n\tБаланс: {Ac2.GetBalance()}");
            Console.ReadKey();

        }
    }
    class Acount<T>
    {
        private T number;
        private decimal balance;
        private string fullname;

        public decimal Balance 
        { 
            get => balance; 
            set=> balance=value; 
        }
        public string Fullname
        {
            get => fullname;
            set => fullname = value;
        }
        public T Number
        {
            get => number;
            set => number = value;
        }

        public T GetNumber()
        {
            return number;
        }
        public void SetNumber(T n)
        {
            Number = n;
        }

        public decimal GetBalance()
        {
            return balance;
        }
        public void SetBalance(decimal b)
        {
            Balance = b;
        }

        public string GetFullname()
        {
            return fullname;
        }
        public void SetFullname(string f)
        {
            Fullname = f;
        }
    }    
}
