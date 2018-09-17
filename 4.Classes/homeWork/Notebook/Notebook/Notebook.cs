using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.	Разработать один из классов, в соответствии с полученным вариантом.
//2.	Реализовать не менее пяти закрытых полей (различных типов), представляющих основные характеристики рассматриваемого класса.
//3.	Создать не менее трех методов управления классом и методы доступа к его закрытым полям. 
//4.	Создать метод, в который передаются аргументы по ссылке. 
//5.	Создать не менее двух статических полей (различных типов), представляющих общие характеристики объектов данного класса. 
//6.	Обязательным требованием является реализация нескольких перегруженных конструкторов, аргументы которых определяются студентом,
//      исходя из специфики реализуемого класса, а так же реализация конструктора по умолчанию.
//7.	Создать статический конструктор.
//8.	Создать массив (не менее 5 элементов) объектов созданного класса.
//9.	Создать дополнительный метод для данного класса в другом файле, используя ключевое слово partial


namespace Notebook
{
    public partial class Notebook
    {
        private string _mark { set; get; }
        private double _weight { set; get; }
        private string _color { set; get; }
        private int _batteryCapacity { set; get; }
        private OperatingSystem _operatingSystem { set; get; }
        static int countNotebooks { set; get; }
        static string shipCompany { set; get; }

        static Notebook()
        {
            countNotebooks = 0;
            shipCompany = "";
            Console.WriteLine("Вызван статический конструктор. ");
        }

        public Notebook()
        {
            _mark = "";
            _weight = 0;
            _color = "";
            _batteryCapacity = 0;
            _operatingSystem = 0;
           
            Console.WriteLine("Вызван конструктор по умолчанию. ");
        }

        public Notebook(string mark)
        {
            _mark = mark;
        }

        public Notebook(string color, string mark)
        {
            _color = color;
            _mark = mark;
        }

        public Notebook(string color, string mark, double weight, int capacity, OperatingSystem operatingSystem)
        {
            _mark = mark;
            _color = color;
            _weight = weight;
            _batteryCapacity = capacity;
            _operatingSystem = operatingSystem;
        }

        public string GetMark(){
            return _mark;
        }

        public void SetMark(string mark)
        {
            _mark = mark;
        }

        public double GetWeight()
        {
            return _weight;
        }

        public void SetWeight(double weight)
        {
            _weight = weight;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public int GetCapacity()
        {
            return _batteryCapacity;
        }

        public void SetCapacity(int capacity)
        {
            _batteryCapacity = capacity;
        }

        public OperatingSystem GetOS()
        {
            return _operatingSystem;
        }

        public void SetOS(OperatingSystem os)
        {
            _operatingSystem = os;
        }
    }
}
