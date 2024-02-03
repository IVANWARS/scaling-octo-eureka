//int[] arr = new int[5];
//arr[0] = 5;
//arr[1] = 6;
//arr[2] = 5;
//arr[3] = 8;
//arr[4] = 9;

//Console.WriteLine(arr[0]);
//Console.WriteLine(arr[1]);
//Console.WriteLine(arr[2]);
//Console.WriteLine(arr[3]);
//Console.WriteLine(arr[4]);

//Console.WriteLine(arr[5]);


//int[] arr = new int[5] { 1, 2, 3, 4, 5 };
//int[] arr = { 1, 2, 3, 4, 5 };




//int n = 10;
//int[] array = { 6, 3, 5, 7, 8, 12, 86, 4, 9, 10 };
//int i = 0;

//while ( i < array.Length )

//{
//if (array[i] % 2 == 0)

//{
//  Console.Write($"{array[i] } ");
// }
//  i = i + 1;
//}


int n = 5;
int[] array = { 10, 3, 6, 2, 1 };
int i = 0;
int max = array[0];

while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];

    }
    i = i + 1;
}
Console.Write(max);