using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Building
    {
        string adress;
        int lenght;
        int width;
        int height;

        string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                if (value == "")
                    adress = "Нет адреса";
                else
                    adress = value;
            }
        }
        int Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                if (value < 1)
                    lenght = 1;
                else
                    lenght = value;
            }
        }
        int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public Building(string adress, int lenght, int width, int height)
        {
            Adress = adress;
            Lenght = lenght;
            Width = width;
            Height = height;
        }
        public string Print()
        {
            return $"Адрес: {adress}; Длина здания: {lenght}; Ширина здания: {width}; Высота здания: {height}";
        }
    }
        
}
