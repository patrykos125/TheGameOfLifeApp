using System;
using System.IO.IsolatedStorage;

namespace TheGameOfLifeApp
{
    internal class TheGameOfLifeService
    {
        private bool[,] array;
        public void setArray(bool[,] a)
        {

            array = a;
        }
        public bool[,] getArray() { return array; }




        public bool[,] nextEra()
        {
            int height = array.GetLength(0);
            int width = array.GetLength(1);

            bool[,] future = new bool[height, width];


            for (int i = 1; i < height - 1; i++)
            {
                for (int j = 1; j < width - 1; j++)
                {
                    int aliveNeighbours = 0;

                    for (int k = -1; k <= 1; k++)
                    {
                        for (int m = -1; m <= 1; m++)
                        {
                            if (array[i + k, j + m]) { aliveNeighbours++; }


                        }
                    }
                    if (array[i, j]) { aliveNeighbours--; }

                   

                        // algorithm 

                    if (array[i, j] && (aliveNeighbours < 2))
                    {
                        future[i, j] = false;
                    }
                    else if (array[i, j] && (aliveNeighbours > 3))
                    {
                        future[i, j] = false;
                    }
                    else if (array[i, j]==false && (aliveNeighbours ==3)){
                        future[i, j] = true;
                    }
                    else
                    {
                        future[i, j] = array[i, j];
                    }







                }

            }

            return future;


        }
    }

      
}