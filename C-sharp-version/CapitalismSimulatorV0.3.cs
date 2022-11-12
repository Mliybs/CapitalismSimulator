using System;
using System.Collections;
using System.Collections.Generic;

public class backup
{
    public List<int> list = new List<int>(){1,2};
    public int A = 1;
}
class main
{
    public static void Main(string[] args)
    {
        backup back = new backup();
        Console.WriteLine(back.A);
    }
}