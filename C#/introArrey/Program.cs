﻿void FillArray (int[]collection)
{
int length = collection.Length;
int index =0;
while (index<length)
{
    collection[index]=new Random() .Next(1,10);
    index++;
}
}

void PrintArray(int []col)//воид название метода(размерность[]название массива)
{
    int count= col.Length;//количество элементов
    int position =0;//позиция в массиве
    while (position<count)//условие
    {
        Console.WriteLine(col[position]);
        position++;//индекс+1
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position =-1;    
    while(index<count)
    {
        if(collection[index]==find)
        {
         position=index;
         break;
        }
        index++;
    }
    return position;
}
int[] array =new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos= IndexOf(array,2);
Console.WriteLine(pos);
