class Program

{
    static void Main(string[] args)
    {
        int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        int[,] array2= new int[3, 3];

        int[] array3 = fillArray(array);

        int[,] array4 = sortArrayAndFillArray(array3, array2);

        printArray(array4);


        int[] fillArray(int[,] array)
        {
            int index = 0;
            int[] array3 = new int[9];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array3[index] = array[i, j];
                    index++;
                }
            }
            return array3;
        }

        int[,] sortArrayAndFillArray(int[] array3, int[,] array2)
        {
            Array.Sort(array3);
            int index = 0;
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = array3[index];
                    index++;
                }
            }
            return array2;
        }

        void printArray(int[,] array4)
        {
            for (int i = 0; i < array4.GetLength(0); i++)
            {
                for (int j = 0; j < array4.GetLength(1); j++)
                {
                    Console.Write(array4[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}