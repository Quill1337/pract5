using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5
{
    internal class Triad
    {
        private int _first;
        private int _second;
        private int _third;

        public Triad(int first, int second, int third)
        {
            _first = first;
            _second = second;
            _third = third;
        }
        public int First
        {
            get { return _first; }
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException($"{nameof(First)} Число должно быть нечетным");
                }
                _first = value;
            }
        }
        public int Second
        {
            get { return _second; }
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException($"{nameof(Second)} Число должно быть нечетным");
                }
                _second = value;
            }
        }
        public int Third
        {
            get { return _third; }
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException($"{nameof(Third)} Число должно быть нечетным");
                }
                _third = value;
            }
        }
        public bool CompareTwo(Triad triad1, Triad triad2) => triad1.First == triad2.First && triad1.Second == triad2.Second && triad1.Third == triad2.Third;
        public bool CompareThree(Triad triad1, Triad triad2, Triad triad3) => triad1.First == triad2.First && triad3.First == triad2.First 
            && triad1.Second == triad2.Second && triad3.Second == triad2.Second
            && triad1.Third == triad2.Third && triad3.Third == triad2.Third;
    }
}
