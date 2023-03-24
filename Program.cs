/// <summary>
/// Запрос размера массива со строками
/// </summary>
/// <returns>Возвращает размер массива, введенный пользователем</returns>
int RequestArraySize()
{
    Console.WriteLine("Enter strings quantity (array size):");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    return arraySize;
}


/// <summary>
/// Запрос строки из консоли
/// </summary>
/// <param name="stringNumber">Параметр для нумерации строки в консоли</param>
/// <returns>Возвращает строку, введенную пользователем</returns>
string RequestString(int stringNumber)
{
    Console.WriteLine($"Enter string #{stringNumber}:");
    string inputString = Console.ReadLine();
    return inputString;
}


/// <summary>
/// Метод заполняет массив строками, запрошенными из консоли методом RequestString()
/// </summary>
/// <param name="arraySize">Параметр размера массива для заполнения</param>
/// <returns>Возвращает заполненный массив</returns>
string[] FillInputArray(int arraySize)
{
  string[] resultArray = new string[arraySize];
  for (int i = 0; i < arraySize; i++)
  {
      resultArray[i] = RequestString(i+1);
  }  
  return resultArray;
}


/// <summary>
/// Метод считает в массиве количество строк, соответствующих заданному количеству символов
/// </summary>
/// <param name="arrayToCheck">Массив, который проверяется на наличие искомых строк</param>
/// <param name="maxStringLength">Максимальная длина строк, которые мы ищем</param>
/// <returns>Возвращает количество найденых строк, соответствующих заданному размеру</returns>
int CountNumberOfValidStrings(string[] arrayToCheck, int maxStringLength)
{
    int arrayLength = arrayToCheck.Length;
    int validStringsQuantity = 0;
    for (int i = 0; i < arrayLength; i++)
    {
        if (arrayToCheck[i].Length <= maxStringLength) validStringsQuantity++;
    }
    return validStringsQuantity;
}


/// <summary>
/// Метод заполняет массив строками, соответствующими заданному количеству символов
/// </summary>
/// <param name="inputArray">Массив для поиска нужных строк</param>
/// <param name="maxStringLength">Максимальная длина строк, которые мы ищем</param>
/// <returns>Возвращает массив, заполненный строками с заданным количеством символов</returns>
string[] FillFilteredArray(string[] inputArray, int maxStringLength)
{
    int inputArrayLength = inputArray.Length;
    int outputArrayLength = CountNumberOfValidStrings(inputArray, maxStringLength);
    string[] outputArray = new string[outputArrayLength];
    int j = 0;
    for (int i = 0; i < inputArrayLength; i++)
    {
        if(inputArray[i].Length <= maxStringLength)
        {
            outputArray[j] = inputArray[i];
            j++;
        }      
    }
    return outputArray;
}


int maxNumberOfSymbols = 3;

string[] inputArray = FillInputArray(RequestArraySize());
Console.WriteLine("Your array:");
Console.WriteLine($"[{String.Join(" , ", inputArray)}]");

string[] resultArray = FillFilteredArray(inputArray, maxNumberOfSymbols);
Console.WriteLine($"Array of strings with {maxNumberOfSymbols} or less symbols:");
Console.WriteLine($"[{String.Join(" , ", resultArray)}]");
