int a = 1; 
int b = 3; 
int c = 4;
int d = 8;
int e = 6;

int max = a;
if (b>max) b = max;
if (c>max) c = max;
if (d>max) d = max;
if (e>max) e = max;

Console.Write("Максимальное число:");
Console.WriteLine(max);