using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Array
{
    private int[] list = new int[] { 3, 6, 2, 8, 1 };

    public bool search(int val, out int number)
    {
        number = 0;
        bool res = false;
        for (int i = 0; i < list.Length; i++)
        {
            if (val == list[i])
            {
                res = true;
                number = i;
            }
        }
        return res;
    }
}


class Q2
{
    static void Main(string[] args)
    {
        Array a = new Array();
        int number;
        bool res = a.search(8,out number);
        if (res == true)
            Console.WriteLine("Value Found at {0}",number);
    }
}
