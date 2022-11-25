using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    sealed class MultiBuilding : Building
    {

        int floors;
        int Floors
        {
            get
            {
                return floors;
            }
            set
            {
                if (value <= 0)
                    floors = 1;
                else
                    floors = value;
            }

        }
        public MultiBuilding(string adress, int lenght, int width, int height, int floors)
            : base(adress, lenght, width, height)
        {
            Floors = floors;
        }

        public string Print()
        {
            string result = base.Print();
            result += $"; Количество этажей: {floors}";
            return result;
        }
    }
        
    }
