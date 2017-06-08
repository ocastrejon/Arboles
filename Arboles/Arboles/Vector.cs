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
        private int[] v = new int[8];

        public Vector()
        {
            
        }

        public int[] llenarVector()
        {
            for (int i = 0; i < v.Length; i++)
                v[i] = x.Next(20);
            Array.Sort(v);

            li = 0;
            ls = v.Length;
            return v;
        }

        public void busquedaBinaria(int num)
        {//Terminar
            int busc = (ls + li) / 2;
            while (busc != li)
            {
                if (num < v[busc])
                {
                    ls = busc;
                    busc = (ls + li) / 2;
                }
                else
                    if (num > v[busc])
                {
                    li = busc;
                    busc = (ls + li) / 2;
                }
            }
        }

        private void busquedaBinaria()
        {

        }
    }
}
