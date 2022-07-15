internal class Program
{
    private static void Main(string[] args)
    {
        void Zadacha34()
        {
            // Задайте массив заполненный случайными положительными трёхзначными числами. 
           // Напишите программу, которая покажет количество чётных чисел в массиве.
            int[] array =new int[5];
            FillArray(array, 100, 200);
            PrintArray(array);
            int count =0 ;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2==0) count++;
            }
            Console.WriteLine("Четных чисел в массиве: "+ count);
        }

        void FillArray(int[] array, int startNumber = 0, int finishNumber = 1)

        {
            finishNumber++ ;
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(startNumber, finishNumber);
            }
        }
        void PrintArray(int[] array)
        {
            Console.WriteLine("Вывод массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }
        Zadacha34();
        
    }
}