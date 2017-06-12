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

        Random x = new Random();
        private int[] v = new int[10];

        public Vector()
        {
            
        }

        public int[] llenarVector()
        {
            for (int i = 0; i < v.Length; i++)
                v[i] = x.Next(20);
            Array.Sort(v);
            return v;
        }

        public int busquedaBinaria(int num)
        {

            li = 0;
            ls = v.Length;
            int busc = (ls + li) / 2;

            while (busc != li)
            {
                if (num == v[busc])
                    return v[busc];
                else if (num < v[busc])
                {
                    ls = busc;
                    busc = (ls + li) / 2;
                    if (num == v[busc])
                        return v[busc];
                }
                else
                    if (num > v[busc])
                {
                    li = busc;
                    busc = (ls + li) / 2;
                    if (num == v[busc])
                        return v[busc];
                }
            }
            return 0;
        }
    }
}
