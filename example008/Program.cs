int Max(int arg1, int arg2, int arg3) {
int result = arg1;
if (arg2>result) result =arg2;
if (arg3>result) result =arg3;
return result;
}


int a = 1111; 
int b = 3; 
int c = 4;
int d = 8;
int e = 63;
int f = 634;
int g = 668;
int h = 61;
int n = 6;

int max = Max(
    Max(a,b,c),
    Max(d,e,f),
    Max(g,h,n)
);

Console.Write("Максимальное число:");
Console.WriteLine(max);