using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListLib
{
    public class MyListLib
    {

        private int LastIndex { get; set; }
        private object[] _array;
        private int _capacity = 5;

        public MyListLib(int capacity)
        {
            _capacity = capacity;
            InitArray();
        }
        public MyListLib()
        {
            InitArray();
        }


        //private void InitArray() => _array = new object[_capacity];

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
            if (index <= _array.Length && index > 0)
            {
                if ((index == _capacity && index == LastIndex) || LastIndex == _capacity)
                {
                    _capacity *= 2;
                    RenitArray();
                }

                for (int i = _capacity - 1; i > index; i--)
                {
                    _array[i] = _array[i - 1];
                }
                _array[index] = obj;
                LastIndex++;
            }
            else
            {
                Console.WriteLine($"Inset false!!!"); ;
            }

        }

        public void Remove(object obj)
        {
            RemoveAt(IndexOf(obj));

        }
        public void RemoveAt(int index)
        {
            if (index < _array.Length && index > 0)
            {
                LastIndex--;
                for (int i = index; i < LastIndex; i++)
                {
                    _array[i] = _array[i + 1];
                }
                _array[LastIndex] = null;
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
                if (Equals(_array[i], obj)) return true;
            }
            return false;
        }

        public int IndexOf(object obj)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (Equals(_array[i], obj))
                {
                    return i;
                }

            }
            return -1;
        }


        public object[] ToArray()
        {
            object[] newArray = new object[_array.Length];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            return newArray;
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
}
