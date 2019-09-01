using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class MyList
    {
        private int LastIndex { get; set; }
        private int Count { get; }
        private object[] _array;
        private int _capacity = 5;

        public MyList(int capacity)
        {
            _capacity = capacity;
            InitArray();
        }
        public MyList()
        {
            InitArray();
        }


        //private void InitArray() => array = new object[_capacity];

        private void InitArray()
        {

            _array = new object[_capacity];

        }
        private void RenitArray()
        {
            object[] newArray = _array;
            _array = new object[_capacity];
            if (_array != null)
            {
                for (int i = 0; i < newArray.Length; i++)
                {
                    _array[i] = newArray[i];
                }
            }
        }

        public void Add(int newValue)
        {
            if (LastIndex == _capacity)
            {
                _capacity *= 2;
                RenitArray();
            }
            _array[LastIndex] = newValue;
            LastIndex++;
        }

        public void Insert(int index, object obj)
        {
            if (index < _array.Length)
            {
                if (LastIndex == index)
                {
                    _array[index] = obj;
                    LastIndex++;
                }
                else
                {
                    Console.WriteLine($"Invalid index !!!");
                }
            }
            else if(index == _capacity && index == LastIndex)
            {
                _capacity *= 2;
                RenitArray();
                _array[index] = obj;
                LastIndex++;
            }
            else
            {
                Console.WriteLine($"Inset false!!!");
            }
        }

        public void Remove(object obj)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == obj)
                {
                    _array[i] = null;
                }
            }
        }
        public void RemoveAt(int index)
        {
            if (index < _array.Length)
            {
                _array[index] = null;
            }
            else
            {
                Console.WriteLine($"Remove false!!!");
            }
        }

        public void Clear()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = null;
            }
        }

        public bool Contains(object obj)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == obj) return true;
            }
            return false;
        }

        public int IndexOf(object obj)
        {
            int index;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == obj)
                {
                    index = (int)_array[i];
                    return index;
                }

            }
            return -1;
        }


        public object[] ToArray()
        {
            return _array;
        }

        public void Reverse()
        {
            for (int i = 0, j = _array.Length - 1; i < j; i++, j--)
            {
                object temp = _array[i];
                _array[i] = _array[j];
                _array[j] = temp;
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            MyList array = new MyList();
            array.Add(4);
            array.Add(7);
            array.Add(9);
            array.Add(15);
            array.Add(30);
           
            var rr = array.ToArray();
            var l = rr.Length;
            foreach (var i in rr)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine($"Next array\n");
            array.Insert(5, 56);
            array.Insert(6, 145);
            array.Insert(7, 22);
            array.Insert(9, 7);

            var rr1 = array.ToArray();
            foreach (var i in rr1)
            {
                Console.WriteLine($"{i}");
            }

            Console.ReadLine();
        }
    }
}
