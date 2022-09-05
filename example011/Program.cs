int[] array = {1,35,56,346,7567,875678,343,22,1};
int n = array.Length;
int index=0;
int find=1;

while (index<n) {
    if (array[index]==find)
    {
        Console.Write(index);
        break;
    }
    index++;
}

