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




int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < n)
{
    arr[i] = i + 1;
    //Console.Write(arr[i]);
    //Console.Write(' ');
    Console.Write($"{arr[i]} ");
    i = i + 1;
     
}