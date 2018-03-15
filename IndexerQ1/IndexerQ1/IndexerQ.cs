using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Values
{
    private int val1;
    private int val2;
    private int val3;

    public Values(int v1, int v2, int v3)
    {
        val1 = v1;
        val2 = v2;
        val3 = v3;
    }

    public void print()
    {
        Console.Write("[ ");
        Console.Write("{0}  ", val1);
        Console.Write("{0}  ", val2);
        Console.Write("{0}  ", val3);
        Console.WriteLine("] ");
    }

    public int this[int index]
    {
        set
        {
            if(index == 0)
            {
                val1 = value;
            }
            else if (index == 1)
            {
                val2 = value;
            }
            else if (index == 2)
            {
                val1 = value;
            }
        }

        get
        {
            if(index == 0)
            {
                return val1;
            }
            else if(index == 1)
            {
                return val2;
            }
            else if(index == 2)
            {
                return val3;
            }
            else
            {
                return 0;
            }
        }
    }
    
}

public class IndexerQ
{
    public static void Main()
    {

        Values v = new Values(3, 4, 5);
        v.print();
        v[1] = 9;                                      // set  val2=9
        Console.WriteLine("value={0}", v[2]);	        // get  val3
        v.print();
    }
}