using System;


namespace FanOutPut2
{
    public class FanOutPut
    {
        private int _id;
        private string _name;
        private int _temp;
        private int _fugt;

        public FanOutPut(int id, string name, int temp, int fugt)
        {
            _id = id;
            _name = name;
            _temp = temp;
            _fugt = fugt;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length < 2) throw new ArgumentOutOfRangeException();
                _name = value;
            }
        }

        public int Temp
        {
            get { return _temp; }
            set
            {
                if (value < 15 || value > 25) throw new ArgumentOutOfRangeException();

                _temp = value;
            }

        }

        public int Fugt
        {
            get { return _fugt; }
            set
            {
                if (value < 30 || value > 80) throw new ArgumentOutOfRangeException();
                _fugt = value;
            }
        }
        public FanOutPut() { }
    }
}

