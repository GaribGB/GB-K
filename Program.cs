
Console.Clear();
int quantity = Input("Введите количество элементов в исходном массиве: ");
string[] arrayString = new string [quantity];

PrintArray(arrayResult, quantityResult);

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayString(string[] array, int count)
{
    for(int i=0 ; i<count ; i++)
    {
        Console.Write($"Введите элемент массива №{i+1}: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
}

