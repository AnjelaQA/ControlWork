
void FormulatingArrayResult(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
     if(array1[i].Length <= 3)
        {
         array2[j] = array1[i];
         j++;
        }
    }
}

void PrintArrayResult (string[] array){
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
