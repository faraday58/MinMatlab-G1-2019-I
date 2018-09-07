using System;

namespace MinMatlab_G1_2019_I
{
    class Multidimensional : Matriz
    {
        private float[,] matriz;

        public Multidimensional(byte M, byte N)
        {
            this.M = M;
            this.N = N;
            matriz = new float[M, N];
        }

        public static Multidimensional Leer(string matriz)
        {
            string[] renglones = matriz.Split(';');
            string[] columnas = renglones[0].Split(' ');
            Multidimensional m1 = new Multidimensional((byte)renglones.Length, (byte)columnas.Length);

            for (int i = 0; i < m1.M; i++)
            {
                columnas = renglones[i].Split(' ');
                for (int j = 0; j < m1.N; j++)
                {
                    m1.matriz[i, j] = float.Parse(columnas[j]);
                }

            }
            return m1;
        }

        public override string ToString()
        {
            string  aux = "";
            for(int i=0; i < M; i ++)
            {
                for(int j=0; j < N; j ++ )
                {
                    aux = aux + " " + matriz[i, j];
                }
                aux = aux + "\n";
            }

            return aux;
        }



    }
}
