using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_methods
{
   



class computer
{
    static void Main()
    {
        int[] oldArray = { 54, 95, 82, 54, 45, 10, 23 };
        int[] newelement = { 21, 45, 89, 12, 32,454 };
        int[] newArray = new int[oldArray.Length + newelement.Length];
        for (int i = 0; i < oldArray.Length; i++)
        {
            newArray[i] = oldArray[i];
        }
        for (int i = 0; i < newelement.Length; i++)
        {
            newArray[oldArray.Length + i] = newelement[i];
        }
        Console.WriteLine("Old Array:");
        PrintArray(oldArray);
        Console.WriteLine("New Array:");
        PrintArray(newArray);
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

}
}


