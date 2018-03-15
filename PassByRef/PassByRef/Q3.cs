using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*    Fail  =  mark <40
      Pass  =   40<=mark<60
      Honour=  mark>=60
*/

class ArrayFn
{
    private int[] arr = new int[] { 38, 58, 19, 92, 52, 55, 11, 84 };


    public int getResults(out int result2, out int result3)
    {
        int result1 = 0;
        result2 = 0;
        result3 = 0;
        for(int i = 0; i<arr.Length; i++)
        {
            if(arr[i]<40)
            {
                result1++;       
            }
            else if(arr[i]>=40 && arr[i]<60)
            {
                result2++;
            }
            else if(arr[i]>=60)
            {
                result3++;
            }
        }
        return result1;
    }
}


public class Ex1
{

    public static void Main()
    {
        ArrayFn af = new ArrayFn();
        int result2;
        int result3;
        int res1 = af.getResults(out result2,out result3);
        Console.WriteLine("\nFails: " + res1);
        Console.WriteLine("\nPasses=: " + result2);
        Console.WriteLine("\nHonours=: " + result3);
    }
}
