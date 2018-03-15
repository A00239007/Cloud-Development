using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Name
{
    private string first;
    private string last;

    public Name(string s)
    {
        int index = s.LastIndexOf(" ");
        first = s.Substring(0, index + 1);
        last = s.Substring(index + 1);
    }

    public void print()
    {
        Console.WriteLine("First: " + first);
        Console.WriteLine("Last : " + last);
    }

    public String this[int index]
    {
        set
        {
            if(index == 0)
            {
                first = value;
            }
            else if(index == 1)
            {
                last = value;
            }
        }

        get
        {
            if (index == 0)
            {
                return first;
            }
            else if (index == 1)
            {
                return last;
            }
            else
            {
                return "bepis";
            }
        }
    }
}

public class IndexerQ2
{
    public static void Main() 
    {

        Name n = new Name("John Joseph Smith");
        n.print();
        n[1] = "Jones";                                      // set  val2=9
        Console.WriteLine("First Name={0}", n[0]);	        // get  val3
        n.print();
    }
}