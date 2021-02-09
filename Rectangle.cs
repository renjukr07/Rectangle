using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    public class Rectangle
    {
        private int _length;
        private int _width;

        public Rectangle()
        {
            this._length = 1;
            this._width = 1;
        }
        public Rectangle(int l, int w)
        {
            this._length = l;
            this._width = w;
        }
        public int GetLength()
        {
            return _length;
        }
        public int SetLength(int length)
        {
            _length = length;
            return _length;
        }
        public int GetWidth()
        {
            return _width;
        }
        public int SetWidth(int width)
        {
            _width = width;
            return _width;
        }
        public int GetPerimeter()
        {
            return _length + _width;
        }
        public int GetArea()
        {
            return _length * _width;
        }

    }
}
