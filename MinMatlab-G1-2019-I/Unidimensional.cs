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
