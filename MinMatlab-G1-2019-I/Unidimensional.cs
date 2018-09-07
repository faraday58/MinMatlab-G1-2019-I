using System;

namespace MinMatlab_G1_2019_I
{
    class Unidimensional:Matriz
    {
        private float[] matriz;

       public  Unidimensional(byte N)
        {
            this.N = N;
            matriz = new float[N];
        }

        public static Unidimensional Leer(string matriz)
        {
            // 4 5 6 7
            string[] columnas = matriz.Split(' ');
            Unidimensional matunidimensional = new Unidimensional((byte)columnas.Length);
            for(int i=0; i < matunidimensional.N; i++)
            {
                matunidimensional.matriz[i] = float.Parse(columnas[i]);
            }

            return matunidimensional;

        }

        public static Unidimensional operator +(Unidimensional u1 , Unidimensional u2)
        {
            Unidimensional u3 = new Unidimensional(u1.N);
            for( int i=0; i < u3.N; i++)
            {
                u3.matriz[i] = u1.matriz[i] + u2.matriz[i];
            }
            return u3;
        }



        public override string ToString()
        {
            string aux="";
            // 1 2 3 4
            for( int i = 0; i < N; i++)
            {
                aux = aux + " " + this.matriz[i];
            }

            return aux;
        }


    }
}
