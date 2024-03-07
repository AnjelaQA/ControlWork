
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
// String[] arrayStart = new string[5] {"123", "andhfajs", "gsg", "1sdf", "12"};
String[] arrayStart = new string[5] {"Hello", "2", "world", ":-)", "45"};
String[] arrayResult = new string[arrayStart.Length];

