using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_2
{
    class bai1
    {
        private int x;
        private int y;
        private string name;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bai1()
        {
            x = 0;
            y = 0;
            name = "Origin";
        }

        public bai1(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name} ({x}, {y})";
        }
    }

}
