
    //определение размера массива
    Console.WriteLine("Введите размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());

    //объявление массива
    string[] array = new string[size];

    //переменная, в которой определяетя размер результирующего массива
    int res_count = 0;

    //заполнение исходного массива
    FillArray();

    //объявление результирующего массива
    string[] result_array = new string[res_count];
    //переменная, в которой определяется индекс для элемента результирующего массива
    int j = 0;

    //заполнение результирующего массива
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result_array[j] = array[i];
            j++;
        }
    }

    //результирующий массив преобразуем в строку для вывода
    string result = string.Join(",", result_array);
    Console.Write(result);




void FillArray()
{
    Console.WriteLine("Введите значения элементов массива. Каждое значение вводится с новой строки");

    for (int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine();

        //если новое значение элемента массива <= 3, увеличиваем размер результируюшего массива     
        if (array[i].Length <= 3) res_count++;
    }
}



