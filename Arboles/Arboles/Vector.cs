using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Vector
    {
        private int _li;
        public int li { get { return _li; } set { _li = value; } }
        private int _ls;
        public int ls { get { return _ls; } set { _ls = value; } }
        private int _pos;
        public int pos { get { return _pos; }  set { _pos = value; } }
        private int _compa;
        public int compa { get { return _compa; } set { _compa = value; } }

        Random x = new Random();
        private int[] v = new int[500];

        public Vector()
        {
            pos = 0;
            compa = 0;
        }

        public int[] llenarVector()
        {
            for (int i = 0; i < v.Length; i++)
                v[i] = x.Next(10000);
            Array.Sort(v);
            return v;
        }

        public int busquedaBinaria(int num)
        {
            compa = 0;
            li = 0;
            ls = v.Length;
            int busc = (ls + li) / 2;

            while (busc != li)
            {
                compa++;
                if (num == v[busc])
                {
                    pos = busc;
                    return v[busc];
                }
                else if (num < v[busc])
                {
                    ls = busc;
                    busc = (ls + li) / 2;
                    compa++;
                    if (num == v[busc])
                    {
                        pos = busc;
                        return v[busc];
                    }
                }
                else
                    if (num > v[busc])
                {
                    li = busc;
                    busc = (ls + li) / 2;
                    compa++;
                    if (num == v[busc])
                    {
                        pos = busc;
                        return v[busc];
                    }
                }
            }
            return 0;
        }
    }
}
