// 1
// int max = int.MinValue;
// for (;;)
// {
//     int a = Convert.ToInt32(Console.ReadLine());
//     if(a==0)break;
//     if(a>max)max=a;
// }
// System.Console.WriteLine(max);

// 2
// double a, b, sum=0;
// a = Convert.ToInt32(Console.ReadLine());
// b = Convert.ToInt32(Console.ReadLine());
// for(int i=0; i<=b; i++)
// {
//     sum+=Math.Pow(a,i);
// }
// System.Console.WriteLine(sum);

// 3
// int cnt = 0;
// int pew = -1;

// for(;;)
// {
//     int a = Convert.ToInt32(Console.ReadLine());
//     if(pew == 0 && a == 0)
//     {
//         break;
//     }
//     cnt+= a;

//     pew = a;
// }
// System.Console.WriteLine(cnt);


// 4
// int num = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [num];
// for(int i=0; i<num; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// bool f = false;
// for(int i=0; i<num-1; i++)
// {
//     if(arr[i]>0 && arr[i+1]>0 || arr[i]<0 && arr[i+1]<0){f=true; break;}
// }
// if(f) System.Console.WriteLine("YES");
// else System.Console.WriteLine("NO");
 

// 6
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];

// for (int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int min = arr[0];   

// for (int i = 1; i < a; i++)
// {
//     if (arr[i] < min)
//     {
//         min = arr[i];
//     }
// }

// Console.WriteLine(min);

// 7
// int sum = 0;
// int cnt = 0;

// while (true)
// {
//     Console.WriteLine("Give a number:");
//     Console.Write("> ");

//     int i = Convert.ToInt32(Console.ReadLine());

//     if (i == 0)
//         break; 

//     sum += i;
//     cnt++;
// }

// Console.WriteLine("Sum of numbers: " + sum);
// Console.WriteLine("Count of numbers: " + cnt);

// 8
// int a, c, p=1, sum=0;
// a = Convert.ToInt32(Console.ReadLine());

// for(int i = a;i > 0; i/=10)
// {
//     c = i % 10;
//     sum += c;
//     p *= c;
// }
// System.Console.WriteLine(sum);
// System.Console.WriteLine(p);

// 9
// int a, rev = 0;
// a = Convert.ToInt32(Console.ReadLine());

// for(int i = a;i > 0;i/=10)
// {
//     rev = rev * 10 + i % 10;
// }
// System.Console.WriteLine(rev);