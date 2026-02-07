// 1;

double sum;
sum = Convert.ToInt32(Console.ReadLine());
if (sum < 100)
{
    sum += sum * 0.05;
}
else if (sum <= 200)
{
    sum += sum * 0.07;
}
else
{
    sum += sum * 0.10;
}

Console.WriteLine(sum);


// 2;

// int n = Convert.ToInt32(Console.ReadLine());

// int p = 1;
// string o = "";

// for (int i = 0; i < n; i++)
// {
//     int x = Convert.ToInt32(Console.ReadLine());

//     p *= x;

//     o += x;
//     if (i != n - 1)
//         o += "*";
// }

// Console.WriteLine(o + " = " + p);

// 3;

// int n = Convert.ToInt32(Console.ReadLine());
// int[] a = new int[n];

// for (int i = 0; i < n; i++)
//     a[i] = Convert.ToInt32(Console.ReadLine());

// int max = a[0], index = 0;

// for (int i = 1; i < n; i++)
// {
//     if (a[i] > max)
//     {
//         max = a[i];
//         index = i;
//     }
// }

// Console.WriteLine(index);


// 4;

// int n = Convert.ToInt32(Console.ReadLine()); 
// string[] arr = new string[n];

// for (int i = 0; i < n; i++)
//     arr[i] = Console.ReadLine(); 

// for (int i = 0; i < n; i++)
// {
//     bool c = true;
//     for (int j = 0; j < n; j++)
//     {
//         if (i != j && arr[i] == arr[j])
//         {
//             c = false;
//             break;
//         }
//     }
//     if (c)
//         Console.Write(arr[i] + " ");
// }


// 5;

// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for (int i = 0; i < n; i++) arr[i] = Convert.ToInt32(Console.ReadLine());

// int min = arr[0], index = 0;

// for (int i = 1; i < n; i++)
// {
//     if (arr[i] < min)
//     {
//         min = arr[i];
//         index = i;
//     }
// }

// Console.WriteLine(index);


// 6;

// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for (int i = 0; i < n; i++)
//     arr[i] = Convert.ToInt32(Console.ReadLine());

// int cnt = 0;

// for (int i = 1; i < n - 1; i++)
// {
//     if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
//         cnt++;
// }

// Console.WriteLine(cnt);


// 7;

// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for (int i = 0; i < n; i++)
//     arr[i] = Convert.ToInt32(Console.ReadLine());

// int f = 0, s = 0;
// bool b = false;

// for (int i = 0; i < n - 1; i++)
// {
//     if ((arr[i] > 0 && arr[i + 1] > 0) || (arr[i] < 0 && arr[i + 1] < 0))
//     {
//         f = arr[i];
//         s = arr[i + 1];
//         b = true;
//     }
// }

// if (b) Console.WriteLine(f + " " + s);

// 8;

// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for (int i = 0; i < n; i++)
//     arr[i] = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < n; i++)
// {
//     if (arr[i] % 2 != 0)
//         Console.Write(i + " ");
// }


// 9;

// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for (int i = 0; i < n; i++)
//     arr[i] = Convert.ToInt32(Console.ReadLine());

// int start = Convert.ToInt32(Console.ReadLine()); 
// int end = Convert.ToInt32(Console.ReadLine()); 

// for (int i = start; i <= end; i++)
// {
//     if (arr[i] % 2 != 0)
//         Console.Write(arr[i] + " ");
// }


// 10;

// int n = Convert.ToInt32(Console.ReadLine());
// int[] a = new int[n];

// for (int i = 0; i < n; i++)
//     a[i] = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < n; i++)
// {
//     if (a[i] % 2 != 0)
//         Console.Write(a[i] * a[i] + " ");
// }
