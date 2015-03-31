using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCityTest
{
    class Calculator
    {
        private List<int> numbers;

        private int screen;

        public Calculator()
        {
            numbers = new List<int>();
        }

        public void EnterNumber(int number)
        {
            numbers.Add(number);
        }

        public void Add()
        {
            screen = numbers.Aggregate((x, y) => x + y);
        }

        public int GetScreen()
        {
            return screen;
        }
    }
}
