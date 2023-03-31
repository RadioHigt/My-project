using System;
using System.Collections.Generic;
public class Train 
{ 
    public string Punct; 
    public int Number; 
    public DateTime Time= new DateTime(); 
    public void Print() 
    { 
        Console.WriteLine($"{Punct}"); 
        Console.WriteLine($"{Time}"); 
    } 
}
