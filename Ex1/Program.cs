/* Написать программу которая из имеющегося массива строк формирует массив из строк, 
длина которыйх меньше либо равна 3 символа. Первоначальный массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма.
*/

using static System.Console;
Clear();

string[] array1 = new string[7] { "24", "Tony", "Huawey", "12", "No", "Yes", "Moon" };
string[] array2 = new string[array1.Length];

ResultArray(array1, array2);
PrintArray(array1);
PrintArray(array2);


void ResultArray(string[] array1, string[] array2)
{
	int item = 0;
	for (int i = 0; i < array1.Length; i++)
	{
		if (array1[i].Length <= 3)
		{
			array2[item] = array1[i];
			item++;
		}
	}
}


void PrintArray(string[] array)
{
	Write("[");

	for (int i = 0; i < array.Length; i++)
	{
		Write($"{array[i]},");

	}
	//Write($"{array[array.Length - 1]}");
	Write("]");
	WriteLine();
}
