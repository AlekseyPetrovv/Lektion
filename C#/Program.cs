int Max(int arg1, int arg2, int arg3 )
{
    int result = arg1;
    if (result<arg2)  result=arg2;
    if (result<arg3)  result=arg3;
    return result;
}





int a1 = 15;
int a2 = 21;
int a3 = 39;
int b1 = 125;
int b2 = 21;
int b3 = 323;
int c1 = 12;
int c2 = 23;
int c3 = 33;

int max1=Max(a1,b1,c1);
int max2=Max(a2,b2,c2);
int max3=Max(a3,b3,c3);
int max = Max(max1,max2,max3);


Console.WriteLine(max);
