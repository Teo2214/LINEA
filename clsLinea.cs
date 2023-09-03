using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linea
{
    class clsLinea
    {
        private int X;
        private int Y;
        private int X2;
        private int Y2;
        private static int contar = 0;

        public clsLinea()
        {
            X = 0;
            Y = 0;
            X2 = 0;
            Y2 = 0;
        }

        public clsLinea(double x, double y, double x2, double y2)
        {
            this.X = (int)x;
            this.Y = (int)y;
            this.X2 = (int)x2;
            this.Y2 = (int)y2;
        }

        public int obtenx()
        {
            return X;
        }

        public int obtenx2()
        {
            return X2;
        }


        public int obteny()
        {
            return Y;
        }

        public int obteny2()
        {
            return Y2;
        }

        public void cambiarx(int x)
        {
            this.X = x;
        }

        public void cambiarx2(int x2)
        {
            this.X2 = x2;
        }
        public void cambiary(int y)
        {
            this.Y = y;
        }

        public void cambiary2(int y2)
        {
            this.Y2 = y2;
        }

        public static int obtenContar()
        {
            contar += 1;
            return contar;
        }
    }
}
