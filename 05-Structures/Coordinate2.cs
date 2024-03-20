using System;

namespace _05_Structures
{
    public struct Coordinate2
    {
        private int _x, _y;
        public event Action<int> CoordinatesChanged;

        public int x
        {
            get { return this._x; }
            set
            {
                this._x = value;
                CoordinatesChanged(this._x);
            }
        }

        public int y
        {
            get { return _y; }
            set
            {
                _y = value;
                CoordinatesChanged(this._y);
            }
        }
    }
}