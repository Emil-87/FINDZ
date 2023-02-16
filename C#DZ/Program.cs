void ArrayShow(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

    string[] ArrayFinal = {"hello", "22", "world", ":-)"};
    string[] ArrayEmpty = new string [4];


    for (int i=0; i<ArrayFinal.Length; i++)
    {
      if (ArrayFinal[i].Length <= 3)
     {
      ArrayEmpty[i] = ArrayFinal[i];
      }
    }

  ArrayShow(ArrayEmpty);