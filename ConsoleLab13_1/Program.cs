using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building dom1 = new Building("Регион1, город1, улица1, дом1", 10, 6, 8);
            dom1.Print();
            Console.WriteLine();
            MultiBuilding dom2 = new MultiBuilding("Регион2, город2, улица2, дом2", 14, 10, 16, 4);
            dom2.Print();
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }

    class Building
    {
        public string address;
        public double length;
        public double width;
        public double height;

        public string Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }

        public double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение длины здания");
                }
            }
            get
            {
                return length;
            }
        }

        public double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение ширины здания");
                }
            }
            get
            {
                return width;
            }
        }

        public double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение высоты здания");
                }
            }
            get
            {
                return height;
            }
        }

        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }

        public void Print()
        {
            Console.WriteLine("Здание по адресу: {0}\nДхШхВ = {1}х{2}х{3}", address, length, width, height);
        }
    }

    sealed class MultiBuilding : Building
    {
        public int floor;

        public int Floor
        {
            set
            {
                if (value > 0)
                {
                    floor = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение этажности");
                }
            }
            get
            {
                return floor;
            }
        }
        public MultiBuilding(string address, double length, double width, double height, int floor)
            : base(address, length, width, height)
        {
            Floor = floor;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Количество этажей - {0}", floor);
        }

    }
}
