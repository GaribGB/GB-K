
Console.Clear();
int quantity = Input("Введите количество элементов в исходном массиве: ");
string[] arrayString = new string [quantity];

PrintArray(arrayResult, quantityResult);

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}


