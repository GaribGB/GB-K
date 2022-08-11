
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

void PrintArray(string[] array, int count)
{
    Console.WriteLine("\nСтроки, длина которых меньше либо равна 3 символам: ");
    for(int i=0 ; i<count ; i++)
    {
        Console.Write(array[i]);
        if(i+1 < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write(".\n");
}


FillArrayString(arrayString, quantity);

string[] arrayResult = new string [quantity];
int quantityResult = 0;

for(int i=0 ; i<quantity ; i++)
{
    if(arrayString[i].Length<=3)
    {
        arrayResult[quantityResult] = arrayString[i];
        quantityResult++;
    }
}


